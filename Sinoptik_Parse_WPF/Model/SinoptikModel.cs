using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using HtmlAgilityPack;
using System.Net;

namespace Sinoptik_Parse_WPF.Model
{
    public class SinoptikModel
    {
        private BitmapImage bitmapImage;
        private string _todayWeather;
        private string _todayTime;
        private string _duskDown;
        private string _temperature;
        private int _termometerValue;
        private WebClient webClient = new();
        private HtmlDocument htmlDocument = new();
        private string _downloadString = "https://sinoptik.ua/%D0%BF%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0-%D0%B4%D0%BD%D0%B5%D0%BF%D1%80-303007131";

        public BitmapImage WeathrLogo
        {
            get { return bitmapImage; }
            set { bitmapImage = value; }
        }
        public string TodayWeather
        {
            get => _todayWeather;
            set { _todayWeather = value; }
        }
        public string TodayTime
        {
            get => _todayTime;
            set { _todayTime = value; }
        }
        public string DuskDown
        {
            get => _duskDown;
            set { _duskDown = value; }
        }
        public string Temperature
        {
            get => _temperature;
            set { _temperature = value; }
        }
        public int TermometerValue
        {
            get => _termometerValue;
            set { _termometerValue = value; }
        }
        public SinoptikModel()
        {

        }

        public void WeaterData()
        {
            htmlDocument.LoadHtml(webClient.DownloadString(_downloadString));
            foreach (var item in htmlDocument.DocumentNode.SelectNodes("//p[@class='today-temp']"))
            {
                TodayWeather = item.InnerText.Replace("&deg;", "°");
                var temp = item.InnerText.Replace("&deg;", "").Replace("+", "").Replace("-", "").Replace("C", "");
                TermometerValue = Convert.ToInt32(temp) + 10;
            }
            foreach (var item in htmlDocument.DocumentNode.SelectNodes("//p[@class='today-time']"))
            {
                TodayTime = item.InnerText;
            }
            foreach (var item in htmlDocument.DocumentNode.SelectNodes("//div[@class='infoDaylight']"))
            {
                DuskDown = item.InnerText;
            }
        }

        public void WeaterDataTable(ObservableCollection<string> data)
        {
            htmlDocument.LoadHtml(webClient.DownloadString(_downloadString));
            List<string> lst = new();
            foreach (HtmlNode table in htmlDocument.DocumentNode.SelectNodes("//table[@class='weatherDetails']"))
            {
                foreach (HtmlNode row in table.SelectNodes("//tr"))
                {
                    foreach (HtmlNode cell in row.SelectNodes("//th|td"))
                    {
                        lst.Add(cell.InnerText.Replace("&deg;", "°"));
                    }
                }
            }
            TrimList(lst);
            foreach (var item in lst)
            {
                data.Add(item);
            }
        }

        public void GetImagesInHTML(ObservableCollection<BitmapImage> image)
        {
            htmlDocument.LoadHtml(webClient.DownloadString(_downloadString));

            var imgLogo = htmlDocument.DocumentNode.SelectNodes("//div[@class='imgBlock']//div[@class='img']//img");
            WeathrLogo = ImageConvert(webClient.DownloadData("https:" + imgLogo[0].GetAttributeValue("src", "")));

            var weatherImg = htmlDocument.DocumentNode.SelectNodes("//tr//td//div//img[@class='weatherImg']");
            foreach (var item in weatherImg)
            {
                image.Add(ImageConvert((webClient.DownloadData("https:" + item.GetAttributeValue("src", "")))));
            }
        }

        private BitmapImage ImageConvert(byte[] arr)
        {
            using (MemoryStream ms = new(arr))
            {
                BitmapImage image = new();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = ms;
                image.EndInit();
                return image;
            }
        }

        private List<string> TrimList(List<string> list)
        {
            int start = 0;
            int end = 20;
            int count = end - start;

            list.RemoveRange(start, count);
            return list;
        }
    }
}
