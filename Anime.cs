using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ArzonSearch
{
    class Anime
    {
        public string Animeurl = "";
        public string Title = "";
        public string Introduction = "";
        public string Maker = "";
        public string MakerLabel = "";
        public string Release = "";
        public string Runtime = "";
        public string Num = "";
        public string Tag = "";
        public Image Poster;
        public Anime()
        {

        }
        public async Task GetInfoAsync(string url)
        {
            this.Animeurl = url;
            HtmlDocument doc = await ArzonHttp.GetHtmldocAsync(url);
            if (doc!=null)
            {
                //获取封面
                string Imageurl = doc.DocumentNode.SelectSingleNode("//a[@data-lightbox='jacket1']").GetAttributeValue("href", "未找到");
                Imageurl = "https:" + Imageurl;
                var task = ArzonHttp.GetImageAsync(Imageurl, this.Animeurl);
                //获取Title
                this.Title = doc.DocumentNode.SelectSingleNode(@"//h1").InnerText;
                //获取简介
                try
                {
                    this.Introduction = doc.DocumentNode.SelectSingleNode(@"//div[@class='item_text']").GetDirectInnerText();
                    Match introductionMc = Regex.Match(this.Introduction, @"\S+[\s\S]+\S+");
                    Introduction = introductionMc.Value;
                }
                catch { }
                //获取Maker
                try
                {
                    this.Maker= doc.DocumentNode.SelectSingleNode(@"//table[@class='item']/tr[1]/td[2]/a").InnerText;
                }
                catch { }
                //获取Label
                try
                {
                    this.MakerLabel = doc.DocumentNode.SelectSingleNode(@"//table[@class='item']/tr[2]/td[2]/a").InnerText;
                }
                catch { }
                //获取Release
                try
                {
                    this.Release = doc.DocumentNode.SelectSingleNode(@"//table[@class='item']/tr[3]/td[2]").InnerText;
                    Match releaseMc = Regex.Match(this.Release, @"\d{4}/\d{2}/\d{2}");
                    Release = releaseMc.Value;
                }
                catch { }
                //获取Runtime
                try
                {
                    Runtime = doc.DocumentNode.SelectSingleNode(@"//table[@class='item']/tr[4]/td[2]").InnerText;
                    Match runtimeMc = Regex.Match(this.Runtime, @"\d+分");
                    Runtime = runtimeMc.Value;
                }
                catch { }
                //获取Num
                try
                {
                    Num = doc.DocumentNode.SelectSingleNode(@"//table[@class='item']/tr[5]/td[2]").InnerText;
                    Match numMc = Regex.Match(this.Num, @"\S+");
                    Num = numMc.Value;
                }
                catch { }
                //获取Tag
                try
                {
                    Tag = doc.DocumentNode.SelectSingleNode(@"//table[@class='item']/tr[6]/td[2]/a").InnerText;
                    Match tagMc = Regex.Match(this.Tag, @"\S+");
                    Tag = tagMc.Value;
                }
                catch { }
                this.Poster = await task;
            }
        }
    }
}
