using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryCore
{
    public class VikingLottoNumbers
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
        public List<int> NumCollection { get; set; }
        public List<bool> BoolCollection { get; set; }
        public List<string> ColorCollection { get; set; }

        public int MatchCount { get; set; }

        public VikingLottoNumbers AddDrawNumbers(int num1, int num2, int num3, int num4, int num5, int num6, int additionalNum,
           bool bNum1, bool bNum2, bool bNum3, bool bNum4, bool bNum5, bool bNum6, bool bAdditionalNum)
        {
            Num1 = num1;
            Num2 = num2;
            Num3 = num3;
            Num4 = num4;
            Num5 = num5;
            Num6 = num6;

            AdditionalNum = additionalNum;

            NumCollection = new List<int> { Num1, Num2, Num3, Num4, Num5, Num6 };

            BoolCollection = new List<bool> { bNum1, bNum2, bNum3, bNum4, bNum5, bNum6, bAdditionalNum };
                       
            ColorCollection = new List<string> { ColorNum1, ColorNum2, ColorNum3, ColorNum4, ColorNum5, ColorNum6};



            return this;
        }
        public void GetColorForNum()
        {
            int colorCounter = 0;

            foreach (var numBool in BoolCollection)
            {
                if (colorCounter == 6) break;

                if (numBool == true)
                {
                    ColorCollection[colorCounter] = ColorCode.IsSimilar;
                }
                else
                {
                    ColorCollection[colorCounter] = ColorCode.NotSimilar;
                }
                colorCounter++;
            }
        }
        /// <summary>
        /// Get number in specific draw index
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int GetNum(int num)
        {
            int number = 0;

            switch (num)
            {
                case 1:
                    number = Num1;
                    break;
                case 2:
                    number = Num2;
                    break;
                case 3:
                    number = Num3;
                    break;
                case 4:
                    number = Num4;
                    break;
                case 5:
                    number = Num5;
                    break;
                case 6:
                    number = Num6;
                    break;
                case 7:
                    number = AdditionalNum;
                    break;
            }

            return number;
        }
    }
}
