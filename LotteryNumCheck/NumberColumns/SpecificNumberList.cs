using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumCheck
{
    public class SpecificNumberList
    {
        public ObservableCollection<SpecificNumberAndRepeat> SpecificNumberAndRepeats { get; set; }

        public SpecificNumberList(List<SpecificNumberAndRepeat> list)
        {
            SpecificNumberAndRepeats = new ObservableCollection<SpecificNumberAndRepeat>();

            foreach (var item in list)
            {
                SpecificNumberAndRepeat specificNumberAndRepeat = new SpecificNumberAndRepeat();
                specificNumberAndRepeat.Number = item.Number;
                specificNumberAndRepeat.Repeat = item.Repeat;

                SpecificNumberAndRepeats.Add(specificNumberAndRepeat);
            }
        }
        public void AddColourToNumber(ObservableCollection<VikingLottoNumbers> lottoTask, ObservableCollection<SpecificNumberAndRepeat> NumList,
            int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8, int num9, IProgress<int> progress)
        {
            bool colourSet = false;

            int count = 0;

            foreach (var item in NumList)
            {

                if (item.Number == num1)
                {
                    colourSet = true;
                    item.Colour = "#0f3e0f";
                    item.NumberColour = "White";
                }
                else if (item.Number == num2 && !colourSet)
                {
                    colourSet = true;
                    item.Colour = "#145214";
                    item.NumberColour = "White";
                }
                else if (item.Number == num3 && !colourSet)
                {
                    colourSet = true;
                    item.Colour = "#196719";
                    item.NumberColour = "White";
                }
                else if (item.Number == num4 && !colourSet)
                {
                    colourSet = true;
                    item.Colour = "#1e7b1e";
                    item.NumberColour = "White";
                }
                else if (item.Number == num5 && !colourSet)
                {
                    colourSet = true;
                    item.Colour = "#239023";
                    item.NumberColour = "White";
                }
                else if (item.Number == num6 && !colourSet)
                {
                    colourSet = true;
                    item.Colour = "#28a428";
                    item.NumberColour = "White";
                }
                else if (item.Number == num7 && !colourSet)
                {
                    colourSet = true;
                    item.Colour = "#2db92d";
                    item.NumberColour = "White";
                }
                else if (item.Number == num8 && !colourSet)
                {
                    colourSet = true;
                    item.Colour = "#32cd32";
                    item.NumberColour = "White";
                }
                else if (item.Number == num9 && !colourSet)
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
                if(count == NumList.Count) progress.Report(10);

            }
            
        }
    }
}
