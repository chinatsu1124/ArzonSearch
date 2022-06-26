using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace ArzonSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //static HttpClientHandler handler = new HttpClientHandler()
        //{
        //    Proxy = new WebProxy("http://chinatsu1124.imwork.net:10809"),
        //    UseProxy = true,
        //};
        private List<Aver> Avers = new List<Aver>();
        private List<Anime> Animes = new List<Anime>();
        private List<Magnet> magnets = new List<Magnet>();
        private string savePath = "";
        private string dragFile = "";
        private string fileExt = "";
        private async void btnSearch_ClickAsync(object sender, EventArgs e)
        {
            pgbKeyword.Value = 0;
            //信息框显示"开始搜索..."
            lblProxyTip.Text = "开始搜索...";
            lbxNum.Items.Clear();
            Animes.Clear();
            Avers.Clear();
            pgbKeyword.Value = 25;
            Boolean IfRenewSuccess = await ArzonHttp.RenewCookie();
            pgbKeyword.Value = 50;
            if (IfRenewSuccess)
            {
                string url = @"https://www.arzon.jp";
                string keywords = txtSearch.Text;
                string search_url = @"https://www.arzon.jp//itemlist.html?t=&m=all&s=&q=" + keywords;
                HtmlDocument resultdoc = await ArzonHttp.GetHtmldocAsync(search_url);
                if (resultdoc != null)
                {
                    HtmlNodeCollection nodes;
                    nodes = resultdoc.DocumentNode.SelectNodes("//dl[@class='hentry']/dt/a");
                    if (nodes != null)
                    {
                        List<Task> infotasks = new List<Task>();
                        foreach (var node in nodes)
                        {
                            string item_url = url + node.GetAttributeValue("href", "未找到");
                            Aver aver = new Aver();
                            Task infotask = aver.GetInfoAsync(item_url);
                            infotasks.Add(infotask);
                            Avers.Add(aver);
                        }
                        pgbKeyword.Value = 75;
                        Task t = Task.WhenAll(infotasks.ToArray());
                        await t;
                        t.Dispose();
                        infotasks.Clear();
                        nodes.Clear();
                        int fail = 0;
                        foreach (var Aver in Avers)
                        {
                            if (Aver.Title != "")
                            {
                                lbxNum.Items.Add(Aver.Num);
                            }
                            else { fail++; }
                        }
                        if (fail != 0) { MessageBox.Show(fail.ToString() + "个信息获取失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        pgbKeyword.Value = 100;
                        lblProxyTip.Text = "搜索完成";
                    }
                    else
                    {
                        MessageBox.Show("未搜索到结果，请重新输入关键字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pgbKeyword.Value = 0;
                    }
                }
                else
                {
                    MessageBox.Show("获取搜索结果超时，请尝试使用http代理", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pgbKeyword.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("Cookie更新失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pgbKeyword.Value = 0;
            }
        }

        private void lbxOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lbxNum.SelectedIndex;
            if (Avers.Count != 0)
            {
                if (i >= 0 && i < Avers.Count)
                {
                    tbxTitle.Text = Avers[i].Title;
                    tbxActor.Text = Avers[i].Actor;
                    tbxMaker.Text = Avers[i].Maker;
                    tbxMakerLabel.Text = Avers[i].MakerLabel;
                    tbxSeries.Text = Avers[i].Series;
                    tbxDirector.Text = Avers[i].Director;
                    tbxNum.Text = Avers[i].Num;
                    tbxRelease.Text = Avers[i].Release;
                    tbxRuntime.Text = Avers[i].Runtime;
                    tbxTag.Text = Avers[i].Tag;
                    tbxIntroduction.Text = Avers[i].Introduction;
                    if (cbxFBI.Checked)
                    {
                        pbxPost.Image = Properties.Resources.NoImage;
                    }
                    else if (Avers[i].Poster == null)
                    {
                        lblProxyTip.Text = "图片获取失败";
                    }
                    else { pbxPost.Image = Avers[i].Poster; }
                }
            }
            else if (Animes.Count != 0)
            {
                if (i >= 0 && i < Animes.Count)
                {
                    tbxTitle.Text = Animes[i].Title;
                    tbxActor.Text = "";
                    tbxMaker.Text = Animes[i].Maker;
                    tbxMakerLabel.Text = Animes[i].MakerLabel;
                    tbxSeries.Text = "";
                    tbxDirector.Text = "";
                    tbxNum.Text = Animes[i].Num;
                    tbxRelease.Text = Animes[i].Release;
                    tbxRuntime.Text = Animes[i].Runtime;
                    tbxTag.Text = Animes[i].Tag;
                    tbxIntroduction.Text = Animes[i].Introduction;
                    if (cbxFBI.Checked)
                    {
                        pbxPost.Image = Properties.Resources.NoImage;
                    }
                    else if (Animes[i].Poster == null)
                    {
                        lblProxyTip.Text = "图片获取失败";
                    }
                    else { pbxPost.Image = Animes[i].Poster; }
                }
            }
        }

        private async void btnMagnet_Click(object sender, EventArgs e)
        {
            lbxMagnet.Items.Clear();
            magnets.Clear();
            if (lbxNum.SelectedIndex != -1)
            {
                string magnetKeyword = Avers[lbxNum.SelectedIndex].Num;
                string sukebei_url = @"https://sukebei.nyaa.si/?f=0&c=0_0&q=" + magnetKeyword;
                HtmlDocument doc = await ArzonHttp.GetHtmldocAsync(sukebei_url);
                if (doc != null)
                {
                    HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(@"//tbody/tr");
                    if (nodes != null)
                    {
                        foreach (var node in nodes)
                        {
                            Magnet magnet = new Magnet();
                            magnet.SetInfo(node);
                            magnets.Add(magnet);
                        }
                        nodes.Clear();
                        foreach (var m in magnets)
                        {
                            lbxMagnet.Items.Add(m.title);
                        }
                    }
                    else { MessageBox.Show("未搜索到结果", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else { MessageBox.Show("网络连接超时，请配置代理", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("请在左侧列表选择番号", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void lbxMagnet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lbxMagnet.SelectedIndex;
            tbxMegnetTitle.Text = magnets[i].title;
            tbxMagnetSize.Text = magnets[i].size;
            tbxMagnetSeeders.Text = magnets[i].seeders;
            tbxMagnetLeechers.Text = magnets[i].leechers;
            tbxMagnetCompletes.Text = magnets[i].complete;
            tbxMagnetDate.Text = magnets[i].date;
            tbxMagnetDownload.Text = magnets[i].download;
        }

        private async void btnAnimeSearch_ClickAsync(object sender, EventArgs e)
        {
            pgbKeyword.Value = 0;
            //信息框显示"开始搜索..."
            lblProxyTip.Text = "开始搜索...";
            lbxNum.Items.Clear();
            Avers.Clear();
            Animes.Clear();
            var IfRenewSuccess = await ArzonHttp.RenewCookie();
            pgbKeyword.Value = 25;
            if (IfRenewSuccess)
            {
                string url = @"https://www.arzon.jp";
                string keywords = txtSearch.Text;
                string search_url = @"https://www.arzon.jp/animelist.html?q=" + keywords;
                var resultdoc = await ArzonHttp.GetHtmldocAsync(search_url);
                pgbKeyword.Value = 50;
                if (resultdoc != null)
                {
                    var nodes = resultdoc.DocumentNode.SelectNodes("//dl[@class='hentry']/dt/a");
                    if (nodes != null)
                    {
                        List<Task> tasks = new List<Task>();
                        foreach (var node in nodes)
                        {
                            string item_url = url + node.GetAttributeValue("href", "");
                            Anime anime = new Anime();
                            Task task = anime.GetInfoAsync(item_url);
                            tasks.Add(task);
                            Animes.Add(anime);
                        }
                        pgbKeyword.Value = 75;
                        Task t = Task.WhenAll(tasks.ToArray());
                        await t;
                        t.Dispose();
                        tasks.Clear();
                        nodes.Clear();
                        int fail = 0;
                        foreach (var Anime in Animes)
                        {
                            if (Anime.Title != null)
                            {
                                lbxNum.Items.Add(Anime.Num);
                            }
                            else { fail++; }
                        }
                        if (fail != 0)
                        {
                            MessageBox.Show(fail.ToString() + "个信息获取失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        pgbKeyword.Value = 100;
                        lblProxyTip.Text = "搜索完成";
                    }
                    else
                    {
                        MessageBox.Show("未搜索到结果，请重新输入关键字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pgbKeyword.Value = 0;
                    }
                }
                else
                {
                    MessageBox.Show("获取搜索结果超时，请尝试使用http代理", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pgbKeyword.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("Cookie更新失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pgbKeyword.Value = 0;
            }
        }

        private void btnNFO_Click(object sender, EventArgs e)
        {
            if (lbxNum.SelectedIndex != -1)
            {
                XmlDocument doc = new XmlDocument();
                //创建根节点movie
                XmlElement movie = doc.CreateElement("movie");
                doc.AppendChild(movie);
                //添加介绍
                if (tbxIntroduction.Text != "")
                {
                    XmlElement plot = doc.CreateElement("plot");
                    plot.InnerText = tbxIntroduction.Text;
                    movie.AppendChild(plot);
                }
                //添加标题
                XmlElement title = doc.CreateElement("title");
                title.InnerText = tbxTitle.Text;
                movie.AppendChild(title);
                if (tbxDirector.Text != "")
                {
                    //添加导演
                    XmlElement director = doc.CreateElement("director");
                    director.InnerText = tbxDirector.Text;
                    movie.AppendChild(director);
                }
                //添加发行日期
                XmlElement premiered = doc.CreateElement("premiered");
                premiered.InnerText = tbxRelease.Text.Replace(@"/", @"-");
                movie.AppendChild(premiered);
                //添加工作室
                XmlElement studio = doc.CreateElement("studio");
                if (tbxMakerLabel.Text != "")
                {
                    studio.InnerText = tbxMakerLabel.Text;
                }
                else { studio.InnerText = tbxMaker.Text; }
                movie.AppendChild(studio);
                //添加演员
                if (tbxActor.Text != "")
                {
                    try
                    {
                        string[] sArray = tbxActor.Text.Split(',');
                        foreach (var s in sArray)
                        {
                            XmlElement actor = doc.CreateElement("actor");
                            XmlElement name = doc.CreateElement("name");
                            name.InnerText = s;
                            actor.AppendChild(name);
                            movie.AppendChild(actor);
                        }
                    }
                    catch
                    {
                        XmlElement actor = doc.CreateElement("actor");
                        XmlElement name = doc.CreateElement("name");
                        name.InnerText = tbxActor.Text;
                        actor.AppendChild(name);
                        movie.AppendChild(actor);
                    }
                }
                doc.Save(Path.Combine(savePath, tbxNum.Text + ".nfo"));
                //int thumbWidth = Convert.ToInt32(Avers[i].Poster.Height / (250.4) * (166.94));
                //封面图裁剪
                if (pbxPost.Image.Width > pbxPost.Image.Height)
                {
                    int thumbWidth = Convert.ToInt32(pbxPost.Image.Height * 0.7025);
                    int thumbHeight = pbxPost.Image.Height;
                    Bitmap newbm = new Bitmap(thumbWidth, thumbHeight);
                    Graphics g = Graphics.FromImage(newbm);
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.CompositingQuality = CompositingQuality.HighQuality;
                    g.DrawImage(pbxPost.Image, new Rectangle(0, 0, thumbWidth, thumbHeight), new Rectangle(pbxPost.Image.Width - thumbWidth, 0, thumbWidth, thumbHeight), GraphicsUnit.Pixel);
                    g.Dispose();
                    newbm.Save(Path.Combine(savePath, tbxNum.Text + ".jpg"));
                }
                else { pbxPost.Image.Save(Path.Combine(savePath, tbxNum.Text + ".jpg")); }
                //文件重命名
                if (System.IO.File.Exists(dragFile))
                {
                    //获取文件后缀
                    FileInfo fileInfo = new FileInfo(dragFile);
                    fileInfo.MoveTo(Path.Combine(savePath, tbxNum.Text + fileExt));
                }
                MessageBox.Show("成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("请先选择左侧列表", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] path = (string[])e.Data.GetData(DataFormats.FileDrop);
                dragFile = path[0];
                savePath = Path.GetDirectoryName(dragFile);
                fileExt = Path.GetExtension(dragFile);
                txtSearch.Text = Path.GetFileNameWithoutExtension(dragFile);
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
