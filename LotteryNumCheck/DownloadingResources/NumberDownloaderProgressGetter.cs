using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumCheck
{
    public static class NumberDownloaderProgressGetter
    {
        /// <summary>
        /// The total number of pages.
        /// </summary>
        public static int PageNumber { get; set; }
        /// <summary>
        /// Holds how many pages are currently downloaded.
        /// </summary>
        public static int PageProgress { get; set; }

        public static bool IsEnd { get; set; } = false;
        public static bool IsDone { get; set; } = false;

        public static int GetProcentage()
        {
            int number = (PageProgress * 50) / PageNumber;
            IsDone = false;
            return number;
        }

    }
}
