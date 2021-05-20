using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LotteryNumCheck.AttachedProperties
{
    public class ScrollViewerProperties
    {
        public static readonly DependencyProperty MonitorScrollProperty =
            DependencyProperty.RegisterAttached("MonitorScroll", typeof(bool), typeof(ScrollViewerProperties),
                new FrameworkPropertyMetadata(false, OnScrollChanged));

        private static bool oneCall { get; set; }
        private static int Width { get; set; } = 200;
        private static bool FirstAddDone { get; set; }
        private static void OnScrollChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is ScrollViewer scroll))
                return;

            scroll.ScrollChanged -= Scroll_ScrollChanged;
            scroll.ScrollChanged += Scroll_ScrollChanged;
        }

        private static void Scroll_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            var scroll = sender as ScrollViewer;

            if(scroll.ScrollableWidth > scroll.HorizontalOffset+200 && !FirstAddDone)
            {
                FirstAddDone = true;
                LotteryCore.NoPatterns.Patterns.StopAdding = true;
                LotteryCore.NoPatterns.Patterns.ButtonEnabled = true;
            }
            else if (scroll.ScrollableWidth - scroll.HorizontalOffset < 300 &&
                FirstAddDone && !LotteryCore.NoPatterns.Patterns.AllItemsAdded && !oneCall)
            {
                oneCall = true;
                LotteryCore.NoPatterns.Patterns.PopulatePatterns();
                Width += 400;
            }

            if (scroll.ScrollableWidth > scroll.HorizontalOffset + Width && oneCall)
            {
                oneCall = false;
                LotteryCore.NoPatterns.Patterns.StopAdding = true;
            }
        }

        public static void SetMonitorScroll(ScrollViewer scrollViewer, bool value)
        {
            scrollViewer.SetValue(MonitorScrollProperty, value);
        }
        private static bool GetMonitorScroll(ScrollViewer scrollViewer)
        {
            return true;
        }
    }
}
