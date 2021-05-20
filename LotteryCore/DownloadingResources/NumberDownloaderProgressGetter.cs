using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryCore
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

        public static bool DownloadingIsDone { get; set; } = false;

        public static int GetProcentage()
        {
            int number = (PageProgress * 50) / PageNumber;
            return number;
        }

    }
}
