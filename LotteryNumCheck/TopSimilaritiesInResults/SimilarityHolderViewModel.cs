using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumCheck
{
    public class SimilarityHolderViewModel
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
        public int Num4 { get; set; }
        public int Num5 { get; set; }
        public int Num6 { get; set; }

        public string VisibilityNum1 { get; set; } = "Hidden";
        public string VisibilityNum2 { get; set; } = "Hidden";
        public string VisibilityNum3 { get; set; } = "Hidden";
        public string VisibilityNum4 { get; set; } = "Hidden";
        public string VisibilityNum5 { get; set; } = "Hidden";
        public string VisibilityNum6 { get; set; } = "Hidden";

        public int Repeats { get; set; }
    }
}
