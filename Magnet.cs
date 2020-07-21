using HtmlAgilityPack;

namespace ArzonSearch
{
    public class Magnet
    {
        public string title = "";
        public string download = "";
        public string size = "";
        public string date = "";
        public string seeders = "";
        public string leechers = "";
        public string complete = "";

        public Magnet()
        {

        }
        public void SetInfo(HtmlNode node)
        {
            string html = node.OuterHtml;
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            HtmlNode eachNode = doc.DocumentNode;
            title = eachNode.SelectSingleNode(@"/tr/td[2]/a[not(@class)]").InnerText;
            try
            {
                download = eachNode.SelectSingleNode(@"/tr/td[3]/a[2]").GetAttributeValue("href", "");
            }
            catch { download = eachNode.SelectSingleNode(@"/tr/td[3]/a").GetAttributeValue("href", ""); }
            size = eachNode.SelectSingleNode(@"/tr/td[4]").InnerText;
            date = eachNode.SelectSingleNode(@"/tr/td[5]").InnerText;
            seeders = eachNode.SelectSingleNode(@"/tr/td[6]").InnerText;
            leechers = eachNode.SelectSingleNode(@"/tr/td[7]").InnerText;
            complete = eachNode.SelectSingleNode(@"/tr/td[8]").InnerText;
        }
    }
}
