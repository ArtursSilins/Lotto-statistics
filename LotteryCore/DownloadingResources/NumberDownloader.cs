using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LotteryCore
{
    class NumberDownloader
    {
        public event EventHandler<bool> CachConnectionFail;
        private bool ConnectionFail { get; set; }

        public async Task<ObservableCollection<VikingLottoNumbers>> GetAllNumbersParalelAsync(IProgress<int> progress)
        {
            ObservableCollection<VikingLottoNumbers> vikingLottoNumbersCollection = new ObservableCollection<VikingLottoNumbers>();

            double pageCount = GetPageCount();

            List<Task<List<VikingLottoNumbers>>> vikingLottoTasks = new List<Task<List<VikingLottoNumbers>>>();
            int pageNum = 1;

            while (pageNum <= pageCount)
            {
                vikingLottoTasks.Add(GetNumbers(pageNum));

                NumberDownloaderProgressGetter.PageProgress = pageNum;
                progress.Report(NumberDownloaderProgressGetter.GetProcentage());

                pageNum++;
            }

            var results = await Task.WhenAll(vikingLottoTasks);

            NumberDownloaderProgressGetter.DownloadingIsDone = true;

            int counter = 0;

            foreach (var item in results)
            {
                foreach (var item1 in item)
                {
                    vikingLottoNumbersCollection.Add(item1);
                }

                counter++;
            }

            return vikingLottoNumbersCollection;

        }
        private double GetPageCount()
        {
            DateTime toDay = DateTime.Now;
            DateTime firstResult = new DateTime(2017, 05, 24);
            TimeSpan timeSpan = toDay.Subtract(firstResult);

            double totalWeeks = timeSpan.TotalDays / 7;

            double corectWeek = Math.Ceiling(totalWeeks);

            double pages = corectWeek / 20;

            double corectPageCount = Math.Ceiling(pages);

            NumberDownloaderProgressGetter.PageNumber = Convert.ToInt32(corectPageCount);

            return corectPageCount;
        }
        public async Task<List<VikingLottoNumbers>> GetNumbers(int pageNum)
        {
            List<VikingLottoNumbers> vikingLottoNumbersCollection = new List<VikingLottoNumbers>();

            HtmlWeb web = new HtmlWeb();

            HtmlDocument doc;
            try
            {
                if (pageNum == 1)
                    doc = await web.LoadFromWebAsync("https://www.latloto.lv/lv/arhivs/viking-lotto");
                else
                    doc = await web.LoadFromWebAsync("https://www.latloto.lv/lv/arhivs/viking-lotto" + "/" + pageNum.ToString());

                var num1 = doc.DocumentNode.SelectNodes("/html/body/main/div/section//div/div/div//div//table//tr//td//div/span[1]");
                var num2 = doc.DocumentNode.SelectNodes("/html/body/main/div/section//div/div/div//div//table//tr//td//div/span[2]");
                var num3 = doc.DocumentNode.SelectNodes("/html/body/main/div/section//div/div/div//div//table//tr//td//div/span[3]");
                var num4 = doc.DocumentNode.SelectNodes("/html/body/main/div/section//div/div/div//div//table//tr//td//div/span[4]");
                var num5 = doc.DocumentNode.SelectNodes("/html/body/main/div/section//div/div/div//div//table//tr//td//div/span[5]");
                var num6 = doc.DocumentNode.SelectNodes("/html/body/main/div/section//div/div/div//div//table//tr//td//div/span[6]");
                var additionalNum = doc.DocumentNode.SelectNodes("/html/body/main/div/section//div/div/div//div//table//tr//td//div/span[8]");

                int drawRowCounter = 0;

                while (num1.Count > drawRowCounter)
                {
                    VikingLottoNumbers vikingLottoNumbers = new VikingLottoNumbers();
                    vikingLottoNumbers.AddDrawNumbers(Convert.ToInt16(num1[drawRowCounter].InnerText),
                                                  Convert.ToInt16(num2[drawRowCounter].InnerText),
                                                  Convert.ToInt16(num3[drawRowCounter].InnerText),
                                                  Convert.ToInt16(num4[drawRowCounter].InnerText),
                                                  Convert.ToInt16(num5[drawRowCounter].InnerText),
                                                  Convert.ToInt16(num6[drawRowCounter].InnerText),
                                                  Convert.ToInt16(additionalNum[drawRowCounter].InnerText),
                                                  false, false, false, false, false, false, false);

                    vikingLottoNumbersCollection.Add(vikingLottoNumbers);

                    drawRowCounter++;
                }
            }
            catch (Exception)
            {
                ConnectionFail = true;
                CachConnectionFail?.Invoke(this, ConnectionFail);

            }

            return vikingLottoNumbersCollection;
        }
    }
}
