using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace LotteryNumCheck
{
    public class LiveChart
    {
        private static int Count { get; set; } = 0;

        public static async Task<SeriesCollection> FindFrekvences(ObservableCollection<VikingLottoNumbers> lottoTask)
        {
            string[] lines = new string[1];

            int lottoNum = 0;

            SeriesCollection SeriesCollection = new SeriesCollection();

            List<Task<LineSeries>> lineSeriesTasks = new List<Task<LineSeries>>();


            while (lottoNum < lines.Length)
            {
                lottoNum++;

                LineSeries lineSeries = new LineSeries();
                lineSeries.Title = "Number " + lottoNum.ToString();
                lineSeries.Values = new ChartValues<double>();

                lineSeriesTasks.Add(NewMethod(lottoTask, lottoNum, lineSeries));

            }

            var result = await Task.WhenAll(lineSeriesTasks);

            foreach (var item in result)
            {
                SeriesCollection.Add(item);
            }

            return SeriesCollection;

        }
               
        private static async Task<LineSeries> NewMethod(ObservableCollection<VikingLottoNumbers> lottoTask, int lottoNum, LineSeries lineSeries)
        {

           await Task.Run(async () =>
             {
            int countIs = 0;

                bool detectIs = false;

                int notDropped = 0;

                int weeksCount = 0;

                int firstDetect = 0;
               
                // All results
                foreach (var item in lottoTask)
                {
                    detectIs = false;
                    weeksCount++;

                    // One of results
                    foreach (var num in item.NumCollection)
                    {
                        if (num == lottoNum)
                        {

                            firstDetect++;

                            if (firstDetect == 1 && notDropped > 0)
                            {
                                notDropped = await AddFirstTimeValues(notDropped, lineSeries);
                            }
                            else if (notDropped > 0)
                            {

                                if (notDropped % 2 != 0)
                                {
                                    await AddValuesIfNotDivisible(notDropped, lineSeries);
                                }
                                else
                                {
                                     await AddValuesIfDivisible(notDropped, lineSeries);
                                }

                                notDropped = 0;
                            }
                            else
                            {
                                 double doub = 0;
                                 lineSeries.Values.Add(doub);
                            }

                             detectIs = true;
                            countIs++;

                            break;
                        }

                    }

                    if (!detectIs) notDropped++;

                }


                firstDetect = 0;
                weeksCount = 0;
                notDropped = 0;
            
            });

            return lineSeries;
           
        }

        private static async Task AddValuesIfDivisible(int notDropped, LineSeries lineSeries)
        {
            double half = notDropped / 2;

            double fakeHalf = 0;

            await Task.Run(() =>
            {
                while (fakeHalf < half)
                {
                    fakeHalf++;

                    lineSeries.Values.Add(fakeHalf);
                }

                while (0 <= half)
                {
                    lineSeries.Values.Add(half);

                    half--;
                }

            });
        }

        private static async Task AddValuesIfNotDivisible(int notDropped, LineSeries lineSeries)
        {
            double half = (notDropped - 1) / 2;

            double fakeHalf = 0;

            await Task.Run(() =>
            {
                while (fakeHalf < half)
                {
                    fakeHalf++;

                    lineSeries.Values.Add(fakeHalf);
                }

                lineSeries.Values.Add(fakeHalf + 1);

                while (0 <= half)
                {
                    lineSeries.Values.Add(half);
                    half--;
                }

            });
        }

        private static async Task<int> AddFirstTimeValues(int notDropped, LineSeries lineSeries)
        {
            double notDroppedDouble = notDropped;

            await Task.Run(() =>
            {

                while (notDroppedDouble > -1)
                {
                    lineSeries.Values.Add(notDroppedDouble);

                    notDroppedDouble--;
                }

            });
            notDropped = 0;
            return notDropped;
        }

        public static async Task<string[]> GetLabels(ObservableCollection<VikingLottoNumbers> lottoTask)
        {
            string[] Labels = new string[lottoTask.Count];
            int addWeekCount = 0;

            await Task.Run(() =>
            {
                while (addWeekCount < lottoTask.Count - 1)
                {
                    addWeekCount++;
                    Labels[addWeekCount] = addWeekCount.ToString();

                }
            });

            return Labels;
        }
    }
}
