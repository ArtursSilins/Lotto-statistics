using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumCheck
{
    public static class FindMatchInResults
    {
        public static ObservableCollection<VikingLottoNumbers> GetSimilarities(int lotoNum1,
                                               int lotoNum2,
                                               int lotoNum3,
                                               int lotoNum4,
                                               int lotoNum5,
                                               int lotoNum6,
                                               int lotoAdditionalNum,
                                               ObservableCollection<VikingLottoNumbers> vikingLottoNumbers, int similarityCount)
        {
            ObservableCollection<VikingLottoNumbers> results = new ObservableCollection<VikingLottoNumbers>();


            RessetAllBools(vikingLottoNumbers);


            VikingLottoNumbers lotteryTicketNumbers = new VikingLottoNumbers();
            lotteryTicketNumbers.AddItems(lotoNum1, lotoNum2, lotoNum3, lotoNum4, lotoNum5, lotoNum6, lotoAdditionalNum,
                false, false, false, false, false, false, false);

            int counter = 0;
            int counterForBool = 0;

            foreach (var item in vikingLottoNumbers)
            {
                counter = 0;
                counterForBool = 0;

                VikingLottoNumbers lottoSimilarNumbers = new VikingLottoNumbers();
                foreach (var CollectionItem in item.NumCollection)
                {

                    if (lotteryTicketNumbers.AdditionalNum == item.AdditionalNum && counter == 0)
                    {
                        counterForBool++;
                        item.BoolCollection[6] = true;
                        item.ColorAdditionalNum = ColorCode.IsSimilarAdditionalNum;
                    }
                    else if (lotteryTicketNumbers.AdditionalNum != item.AdditionalNum && counter == 0)
                    {
                        item.ColorAdditionalNum = ColorCode.NotSimilarAdditionalNum;
                    }

                    foreach (var ticketItem in lotteryTicketNumbers.NumCollection)
                    {
                        if (CollectionItem == ticketItem)
                        {
                            counterForBool++;
                            item.BoolCollection[counter] = true;
                        }

                    }
                    counter++;
                }

                if (counterForBool < similarityCount)
                {
                    for (int i = 0; i < item.BoolCollection.Count; i++)
                    {
                        item.BoolCollection[i] = false;
                    }
                }
                else
                {
                    item.GetColorForNum();

                    results.Add(item);
                }
            }

            return results;
        }
        /// <summary>
        /// Resset all Wining number matchd bools to false.
        /// </summary>
        /// <param name="vikingLottoNumbers"></param>
        private static void RessetAllBools(ObservableCollection<VikingLottoNumbers> vikingLottoNumbers)
        {
            foreach (var item in vikingLottoNumbers)
            {
                for (int i = 0; i < item.BoolCollection.Count; i++)
                {
                    item.BoolCollection[i] = false;
                }
            }
        }
    }
}
