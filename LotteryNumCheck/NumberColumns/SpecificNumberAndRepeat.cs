using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumCheck
{
    public class SpecificNumberAndRepeat
    {
        public int Number { get; set; }
        public int Repeat { get; set; }
        public string Colour { get; set; } = "White";
        public string NumberColour { get; set; }
        public string SecondAppearance { get; set; }
    }
}
