using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumCheck
{
    public class WinNumbersList
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
        public int Num4 { get; set; }
        public int Num5 { get; set; }
        public int Num6 { get; set; }

        public string ColorNum1 { get; set; }
        public string ColorNum2 { get; set; }
        public string ColorNum3 { get; set; }
        public string ColorNum4 { get; set; }
        public string ColorNum5 { get; set; }
        public string ColorNum6 { get; set; }
        public string ColorAdditionalNum { get; set; }

        public int AdditionalNum { get; set; }

        public static async Task<ObservableCollection<WinNumbersList>> PopulateWinResultList(ObservableCollection<VikingLottoNumbers> lottoTask, ObservableCollection<WinNumbersList> WinResultList, IProgress<int> progress)
        {
            WinResultList = new ObservableCollection<WinNumbersList>();
            int counter = 0;

            List<Task<WinNumbersList>> winNumbersTasks = new List<Task<WinNumbersList>>();
            foreach (var item in lottoTask)
            {
                winNumbersTasks.Add(WinNumbersTask(counter, item));

                counter++;
            }

            counter = 0;

            var result = await Task.WhenAll(winNumbersTasks);

            foreach (var item in result)
            {
                WinResultList.Add(item);
                counter++;
                if (counter == result.Count()) progress.Report(20);
            }

            return new ObservableCollection<WinNumbersList>(WinResultList);

        }

        private static async Task<WinNumbersList> WinNumbersTask(int counter, VikingLottoNumbers item)
        {
            WinNumbersList winNumbersList = new WinNumbersList();

            await Task.Run(() =>
            {

                winNumbersList.Num1 = item.Num1;
                winNumbersList.Num2 = item.Num2;
                winNumbersList.Num3 = item.Num3;
                winNumbersList.Num4 = item.Num4;
                winNumbersList.Num5 = item.Num5;
                winNumbersList.Num6 = item.Num6;
                winNumbersList.AdditionalNum = item.AdditionalNum;

                if (counter == 0)
                {
                    winNumbersList.ColorNum1 = "#0f3e0f";
                    winNumbersList.ColorNum2 = "#0f3e0f";
                    winNumbersList.ColorNum3 = "#0f3e0f";
                    winNumbersList.ColorNum4 = "#0f3e0f";
                    winNumbersList.ColorNum5 = "#0f3e0f";
                    winNumbersList.ColorNum6 = "#0f3e0f";
                    winNumbersList.ColorAdditionalNum = "#0f3e0f";
                }
                else if (counter == 1)
                {
                    winNumbersList.ColorNum1 = "#145214";
                    winNumbersList.ColorNum2 = "#145214";
                    winNumbersList.ColorNum3 = "#145214";
                    winNumbersList.ColorNum4 = "#145214";
                    winNumbersList.ColorNum5 = "#145214";
                    winNumbersList.ColorNum6 = "#145214";
                    winNumbersList.ColorAdditionalNum = "#145214";
                }
                else if (counter == 2)
                {
                    winNumbersList.ColorNum1 = "#196719";
                    winNumbersList.ColorNum2 = "#196719";
                    winNumbersList.ColorNum3 = "#196719";
                    winNumbersList.ColorNum4 = "#196719";
                    winNumbersList.ColorNum5 = "#196719";
                    winNumbersList.ColorNum6 = "#196719";
                    winNumbersList.ColorAdditionalNum = "#196719";
                }
                //else if (counter == 3)
                //{
                //    winNumbersList.ColorNum1 = "#1e7b1e";
                //    winNumbersList.ColorNum2 = "#1e7b1e";
                //    winNumbersList.ColorNum3 = "#1e7b1e";
                //    winNumbersList.ColorNum4 = "#1e7b1e";
                //    winNumbersList.ColorNum5 = "#1e7b1e";
                //    winNumbersList.ColorNum6 = "#1e7b1e";
                //    winNumbersList.ColorAdditionalNum = "#1e7b1e";
                //}
                else if (counter == 3)
                {
                    winNumbersList.ColorNum1 = "#239023";
                    winNumbersList.ColorNum2 = "#239023";
                    winNumbersList.ColorNum3 = "#239023";
                    winNumbersList.ColorNum4 = "#239023";
                    winNumbersList.ColorNum5 = "#239023";
                    winNumbersList.ColorNum6 = "#239023";
                    winNumbersList.ColorAdditionalNum = "#239023";
                }
                //else if (counter == 5)
                //{
                //    winNumbersList.ColorNum1 = "#28a428";
                //    winNumbersList.ColorNum2 = "#28a428";
                //    winNumbersList.ColorNum3 = "#28a428";
                //    winNumbersList.ColorNum4 = "#28a428";
                //    winNumbersList.ColorNum5 = "#28a428";
                //    winNumbersList.ColorNum6 = "#28a428";
                //    winNumbersList.ColorAdditionalNum = "#28a428";
                //}
                else if (counter == 4)
                {
                    winNumbersList.ColorNum1 = "#2db92d";
                    winNumbersList.ColorNum2 = "#2db92d";
                    winNumbersList.ColorNum3 = "#2db92d";
                    winNumbersList.ColorNum4 = "#2db92d";
                    winNumbersList.ColorNum5 = "#2db92d";
                    winNumbersList.ColorNum6 = "#2db92d";
                    winNumbersList.ColorAdditionalNum = "#2db92d";
                }
                //else if (counter == 7)
                //{
                //    winNumbersList.ColorNum1 = "#32cd32";
                //    winNumbersList.ColorNum2 = "#32cd32";
                //    winNumbersList.ColorNum3 = "#32cd32";
                //    winNumbersList.ColorNum4 = "#32cd32";
                //    winNumbersList.ColorNum5 = "#32cd32";
                //    winNumbersList.ColorNum6 = "#32cd32";
                //    winNumbersList.ColorAdditionalNum = "#32cd32";
                //}
                else if (counter == 5)
                {
                    winNumbersList.ColorNum1 = "#46d246";
                    winNumbersList.ColorNum2 = "#46d246";
                    winNumbersList.ColorNum3 = "#46d246";
                    winNumbersList.ColorNum4 = "#46d246";
                    winNumbersList.ColorNum5 = "#46d246";
                    winNumbersList.ColorNum6 = "#46d246";
                    winNumbersList.ColorAdditionalNum = "#46d246";
                }
                else
                {
                    winNumbersList.ColorNum1 = "#FF3333F3";
                    winNumbersList.ColorNum2 = "#FF3333F3";
                    winNumbersList.ColorNum3 = "#FF3333F3";
                    winNumbersList.ColorNum4 = "#FF3333F3";
                    winNumbersList.ColorNum5 = "#FF3333F3";
                    winNumbersList.ColorNum6 = "#FF3333F3";
                    winNumbersList.ColorAdditionalNum = "#FF640096";
                }

            });
            return winNumbersList;
        }
    }
}
