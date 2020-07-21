using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ArzonSearch
{
    class Aver
    {
        public string Itemurl = "";
        public string Imageurl = "";
        public string Title = "";
        public string Introduction = "";
        public string Actor = "";
        public string Maker = "";
        public string MakerLabel = "";
        public string Series = "";
        public string Director = "";
        public string Release = "";
        public string Runtime = "";
        public string Num = "";
        public string Tag = "";
        public Image Poster;
        public Aver()
        {
        }
        public async Task GetInfoAsync(string url)
        {
            //获取item_url
            this.Itemurl = url;
            //请求页面
            HtmlDocument doc = await ArzonHttp.GetHtmldocAsync(url);
            if (doc != null)
            {
                //获取封面
                this.Imageurl = doc.DocumentNode.SelectSingleNode("//a[@data-lightbox='jacket1']").GetAttributeValue("href", "未找到");
                this.Imageurl = "https:" + this.Imageurl;
                var task = ArzonHttp.GetImageAsync(this.Imageurl, this.Itemurl);
                //获取Title
                HtmlNode titleNode = doc.DocumentNode.SelectSingleNode("//h1");
                this.Title = titleNode.InnerText;
                //获取简介
                try
                {
                    this.Introduction = doc.DocumentNode.SelectSingleNode(@"//div[@class='item_text']").GetDirectInnerText();
                    Match introductionMc = Regex.Match(this.Introduction, @"\S+[\s\S]+\S+");
                    this.Introduction = introductionMc.Value;
                }
                catch { }
                //获取Actor,多名
                try
                {
                    HtmlNodeCollection actornodes = doc.DocumentNode.SelectNodes(@"//table[@class='item']/tr[1]/td[2]/a");
                    for (int i = 0; i < actornodes.Count; i++)
                    {
                        if (i == 0)
                        {
                            this.Actor = actornodes[i].InnerText;
                        }
                        else
                        {
                            this.Actor = this.Actor + "," + actornodes[i].InnerText;
                        }
                    }
                }
                catch { }
                //获取Maker
                try
                {
                    this.Maker = doc.DocumentNode.SelectSingleNode(@"//table[@class='item']/tr[2]/td[2]/a").InnerText;
                }
                catch { }
                //获取MakerLabel
                try
                {
                    this.MakerLabel = doc.DocumentNode.SelectSingleNode(@"//table[@class='item']/tr[3]/td[2]/a").InnerText;
                }
                catch { }
                //获取Series
                try
                {
                    this.Series = doc.DocumentNode.SelectSingleNode(@"//table[@class='item']/tr[4]/td[2]/a").InnerText;
                }
                catch { }
                //获取Director
                try
                {
                    this.Director = doc.DocumentNode.SelectSingleNode(@"//table[@class='item']/tr[5]/td[2]/a").InnerText;
                }
                catch { }
                //获取Release
                try
                {
                    this.Release = doc.DocumentNode.SelectSingleNode(@"//table[@class='item']/tr[6]/td[2]").InnerText;
                    Match releaseMc = Regex.Match(this.Release, @"\d{4}/\d{2}/\d{2}");
                    this.Release = releaseMc.Value;
                }
                catch { }
                //获取Runtime
                try
                {
                    this.Runtime = doc.DocumentNode.SelectSingleNode(@"//table[@class='item']/tr[7]/td[2]").InnerText;
                    Match runtimeMc = Regex.Match(this.Runtime, @"\d+分");
                    this.Runtime = runtimeMc.Value;
                }
                catch { }
                //获取Num
                try
                {
                    this.Num = doc.DocumentNode.SelectSingleNode(@"//table[@class='item']/tr[8]/td[2]").InnerText;
                    Match numMc = Regex.Match(this.Num, @"\S+\d+");
                    this.Num = numMc.Value;
                }
                catch { }
                //获取Tag
                try
                {
                    this.Tag = doc.DocumentNode.SelectSingleNode(@"//table[@class='item']/tr[9]/td[2]/a").InnerText;
                    Match tagMc = Regex.Match(this.Tag, @"\S+");
                    this.Tag = tagMc.Value;
                }
                catch { }
                Poster = await task;
            }
        }
    }
}
