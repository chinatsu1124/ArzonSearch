using System;
using System.Drawing;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ArzonSearch
{
    static class ArzonHttp
    {
        private static string cookie = "PHPSESSID=8ggl83j6djdvupe4p7srgtdfi4";
        //从给定的url获取htmldoc
        public static async Task<HtmlDocument> GetHtmldocAsync(string url)
        {
            HtmlDocument doc = new HtmlDocument();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Cookie", cookie);
            client.Timeout = TimeSpan.FromSeconds(10);
            int retry = 3;
            while (retry > 0)
            {
                try
                {
                    doc.LoadHtml(await client.GetStringAsync(url));
                    return doc;
                }
                catch
                {
                    retry--;
                    Thread.Sleep(50);
                }
            }
            return null;
        }

        //从给定的url获取图片
        public static async Task<Image> GetImageAsync(string url, string item_url)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Cookie", cookie);
            client.DefaultRequestHeaders.Add("Referer", item_url);
            client.Timeout = TimeSpan.FromSeconds(10);
            int retry = 3;
            while (retry > 0)
            {
                try
                {
                    Image image = Image.FromStream(await client.GetStreamAsync(url));
                    return image;
                }
                catch
                {
                    retry--;
                    Thread.Sleep(50);
                }
            }
            return null;
        }

        //Cookies自动续期
        public static async Task<Boolean> RenewCookie()
        {
            string renewUrl = @"https://www.arzon.jp/index.php?action=adult_customer_agecheck&agecheck=1";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Cookie", cookie);
            client.Timeout = TimeSpan.FromSeconds(10);
            try
            {
                var response = await client.GetAsync(renewUrl);
                return response.IsSuccessStatusCode;
            }
            catch { return false; }
        }
    }
}
