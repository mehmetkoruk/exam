using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace examlast.Models
{
    public class getdata
    {


        public getdata()
        {

        }
        public string[] GetData()
        {
            string baslik;

            string[] basliklar = new string[5];
            Uri url = new Uri("http://wired.com");
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string html = client.DownloadString(url);

            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(html);
            HtmlNodeCollection titles = document.DocumentNode.SelectNodes("//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[1]/div[1]/div/ul/li[2]/a[2]/h2");
            foreach (HtmlNode item in titles)
            {

                baslik = item.InnerText;
                basliklar[0] = baslik;

            }
            HtmlNodeCollection titles2 = document.DocumentNode.SelectNodes("//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[1]/div[2]/div/ul/li[2]/a[2]/h2");
            foreach (var item in titles2)
            {
                baslik = item.InnerText;
                basliklar[1] = baslik;
            }
            HtmlNodeCollection titles3 = document.DocumentNode.SelectNodes("//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[1]/div[1]/div/ul/li[2]/a[2]/h2");
            foreach (var item in titles3)
            {
                baslik = item.InnerText;
                basliklar[2] = baslik;
            }
            HtmlNodeCollection titles4 = document.DocumentNode.SelectNodes("//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[1]/div[2]/div/ul/li[2]/a[2]/h2");
            foreach (var item in titles4)
            {
                baslik = item.InnerText;
                basliklar[3] = baslik;
            }
            HtmlNodeCollection titles5 = document.DocumentNode.SelectNodes("//*[@id='app-root']/div/div[3]/div/div/div[2]/div[1]/div/div[1]/div[2]/div[2]/div/ul/li[2]/a[2]/h2");
            foreach (var item in titles5)
            {
                baslik = item.InnerText;
                basliklar[4] = baslik;
            }


            return basliklar;









        }
    }
}
