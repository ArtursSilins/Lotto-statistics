using LotteryCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryCorer
{
    public class ColumnNumberList
    {
        public ObservableCollection<ColumnNumbersAndRepeats> SpecificNumberAndRepeats { get; set; }

        public ColumnNumberList()
        {
          
        }

        public ColumnNumberList(List<ColumnNumbersAndRepeats> list)
        {
            SpecificNumberAndRepeats = new ObservableCollection<ColumnNumbersAndRepeats>();

            foreach (var item in list)
            {
                ColumnNumbersAndRepeats specificNumberAndRepeat = new ColumnNumbersAndRepeats();
                specificNumberAndRepeat.Number = item.Number;
                specificNumberAndRepeat.Repeat = item.Repeat;

                SpecificNumberAndRepeats.Add(specificNumberAndRepeat);
            }
        }

        public void AddColourToAdditionalNum(ObservableCollection<VikingLottoNumbers> lottoTask, ObservableCollection<ColumnNumbersAndRepeats> NumList,
             IProgress<int> progress)
        {
            bool colourSet = false;

            int count = 0;

            foreach (var item in NumList)
            {
                               

                if (item.Number == lottoTask[0].AdditionalNum)
                {
                    colourSet = true;
                    item.Colour = "#0f3e0f";
                    item.NumberColour = "White";
                }
                else if (item.Number == lottoTask[1].AdditionalNum && !colourSet)
                {
                    colourSet = true;
                    item.Colour = "#145214";
                    item.NumberColour = "White";
                }
                else if (item.Number == lottoTask[2].AdditionalNum && !colourSet)
                {
                    colourSet = true;
                    item.Colour = "#196719";
                    item.NumberColour = "White";
                }
                else if (item.Number == lottoTask[3].AdditionalNum && !colourSet)
                {
                    colourSet = true;
                    item.Colour = "#239023";
                    item.NumberColour = "White";
                }
                else if (item.Number == lottoTask[4].AdditionalNum && !colourSet)
                {
                    colourSet = true;
                    item.Colour = "#2db92d";
                    item.NumberColour = "White";
                }
                else if (item.Number == lottoTask[5].AdditionalNum && !colourSet)
                {
                    colourSet = true;
                    item.Colour = "#46d246";
                    item.NumberColour = "White";
                }
                else
                {
                    item.Colour = "White";
                    item.NumberColour = "Black";
                }

                colourSet = false;

                count++;
                if (count == NumList.Count) progress.Report(3);

            }

        }
        /// <summary>
        /// Search for specific number at specific collection index
        /// </summary>
        /// <param name="num"></param>
        /// <param name="drawIndex"></param>
        /// <param name="lottoTask"></param>
        /// <returns></returns>
        private bool SerchNum(int num, int drawIndex, ObservableCollection<VikingLottoNumbers> lottoTask)
        {
            bool equal = false;

            foreach (var item in lottoTask[drawIndex].NumCollection)
            {
                if (item == num) return equal = true;
            }

            return equal;
        }

        public async Task<ObservableCollection<ColumnNumbersAndRepeats>> TopNumbersToColumns(ObservableCollection<VikingLottoNumbers> lottoTask, int num, IProgress<int> progress)
        {

           return await Task.Run(() => AddTopNumbersToColumns(lottoTask, num, progress));

        }

        private ObservableCollection<ColumnNumbersAndRepeats> AddTopNumbersToColumns(ObservableCollection<VikingLottoNumbers> lottoTask, int num, IProgress<int> progress)
        {
            ObservableCollection<ColumnNumbersAndRepeats> numList = new ObservableCollection<ColumnNumbersAndRepeats>();

            List<ColumnNumbersAndRepeats> num1Duplicates = lottoTask.GroupBy(x => x.GetNum(num))
                      .Where(x => x.Count() > 1)
                      .Select(x => new ColumnNumbersAndRepeats { Number = x.Key, Repeat = x.Count() }).OrderByDescending(x => x.Repeat)
                      .ToList();


            ColumnNumberList specificNumberList1 = new ColumnNumberList(num1Duplicates);
            numList = specificNumberList1.SpecificNumberAndRepeats;

            if(num==7)
                specificNumberList1.AddColourToAdditionalNum(lottoTask, numList, progress);
            else
                specificNumberList1.ColourToNumber(lottoTask, numList, progress);

            return numList;
        }
       
        public void ColourToNumber(ObservableCollection<VikingLottoNumbers> lottoTask, ObservableCollection<ColumnNumbersAndRepeats> NumList,
           IProgress<int> progress)
        {
            bool colourSet = false;

            int count = 0;


            List<int> last2DrowDuplicates = new List<int>();

            foreach (var item in lottoTask[0].NumCollection)
            {
                foreach (var item2 in lottoTask[1].NumCollection)
                {
                    if (item == item2) last2DrowDuplicates.Add(item);
                }
            }

            foreach (var item in NumList)
            {

                if (last2DrowDuplicates.Contains(item.Number))
                    item.SecondAppearance = "IndianRed";
                else
                    item.SecondAppearance = "Transparent";

                if (SerchNum(item.Number, 0, lottoTask))
                {
                    colourSet = true;
                    item.Colour = "#0f3e0f";
                    item.NumberColour = "White";
                }
                else if (!colourSet && SerchNum(item.Number, 1, lottoTask))
                {
                    colourSet = true;
                    item.Colour = "#145214";
                    item.NumberColour = "White";
                }
                else if (!colourSet && SerchNum(item.Number, 2, lottoTask))
                {
                    colourSet = true;
                    item.Colour = "#196719";
                    item.NumberColour = "White";
                }
                else if (!colourSet && SerchNum(item.Number, 3, lottoTask))
                {
                    colourSet = true;
                    item.Colour = "#239023";
                    item.NumberColour = "White";
                }
                else if (!colourSet && SerchNum(item.Number, 4, lottoTask))
                {
                    colourSet = true;
                    item.Colour = "#2db92d";
                    item.NumberColour = "White";
                }
                else if (!colourSet && SerchNum(item.Number, 5, lottoTask))
                {
                    colourSet = true;
                    item.Colour = "#46d246";
                    item.NumberColour = "White";
                }
                else
                {
                    item.Colour = "White";
                    item.NumberColour = "Black";
                }

                colourSet = false;

                count++;
                if (count == NumList.Count) progress.Report(3);

            }

        }
    }
}
