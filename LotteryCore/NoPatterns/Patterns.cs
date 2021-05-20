using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace LotteryCore.NoPatterns
{
    public class Patterns
    {
        public static bool ButtonEnabled { get; set; }
        public static bool StopAdding { get; set; }
        public static bool AllItemsAdded { get; set; }
        public static ObservableCollection<DrawSequenceVisualList> _DrawList { get; set; }

        private static Action<DrawNumber> _NumList1  {get;set;}
        private static Action<DrawNumber> _NumList2 { get; set; }
        private static Action<DrawNumber> _NumList3  {get;set;}
        private static Action<DrawNumber> _NumList4  {get;set;}
        private static Action<DrawNumber> _NumList5  {get;set;}
        private static Action<DrawNumber> _NumList6  {get;set;}
        private static Action<DrawNumber> _NumList7  {get;set;}
        private static Action<DrawNumber> _NumList8  {get;set;}
        private static Action<DrawNumber> _NumList9 { get; set; }
        private static Action<DrawNumber> _NumList10 { get; set; }
        private static Action<DrawNumber> _NumList11 {get;set;}
        private static Action<DrawNumber> _NumList12 {get;set;}
        private static Action<DrawNumber> _NumList13 {get;set;}
        private static Action<DrawNumber> _NumList14 {get;set;}
        private static Action<DrawNumber> _NumList15 {get;set;}
        private static Action<DrawNumber> _NumList16 {get;set;}
        private static Action<DrawNumber> _NumList17 {get;set;}
        private static Action<DrawNumber> _NumList18 {get;set;}
        private static Action<DrawNumber> _NumList19 {get;set;}
        private static Action<DrawNumber> _NumList20 {get;set;}
        private static Action<DrawNumber> _NumList21 {get;set;}
        private static Action<DrawNumber> _NumList22 {get;set;}
        private static Action<DrawNumber> _NumList23 {get;set;}
        private static Action<DrawNumber> _NumList24 {get;set;}
        private static Action<DrawNumber> _NumList25 {get;set;}
        private static Action<DrawNumber> _NumList26 {get;set;}
        private static Action<DrawNumber> _NumList27 {get;set;}
        private static Action<DrawNumber> _NumList28 {get;set;}
        private static Action<DrawNumber> _NumList29 {get;set;}
        private static Action<DrawNumber> _NumList30 {get;set;}
        private static Action<DrawNumber> _NumList31 {get;set;}
        private static Action<DrawNumber> _NumList32 {get;set;}
        private static Action<DrawNumber> _NumList33 {get;set;}
        private static Action<DrawNumber> _NumList34 {get;set;}
        private static Action<DrawNumber> _NumList35 {get;set;}
        private static Action<DrawNumber> _NumList36 {get;set;}
        private static Action<DrawNumber> _NumList37 {get;set;}
        private static Action<DrawNumber> _NumList38 {get;set;}
        private static Action<DrawNumber> _NumList39 {get;set;}
        private static Action<DrawNumber> _NumList40 {get;set;}
        private static Action<DrawNumber> _NumList41 {get;set;}
        private static Action<DrawNumber> _NumList42 {get;set;}
        private static Action<DrawNumber> _NumList43 {get;set;}
        private static Action<DrawNumber> _NumList44 {get;set;}
        private static Action<DrawNumber> _NumList45 {get;set;}
        private static Action<DrawNumber> _NumList46 {get;set;}
        private static Action<DrawNumber> _NumList47 {get;set;}
        private static Action<DrawNumber> _NumList48 {get;set;}
        private static DispatcherTimer Timer { get; set; }
        private static Action<string> _PatternsIcon { get; set; }
        private static Action<bool> _IsBusy { get; set; } 
        private static Action<bool> _PatternButtonIsEnabled { get; set; }
        private static Action<string> _PatternProgressVisibility { get; set; }


        public Patterns() { }
        public Patterns(Action<string> PatternsIcon, Action<bool> IsBusy,
            Action<bool> PatternButtonIsEnabled,
            Action<string> PatternProgressVisibility,
            ObservableCollection<DrawSequenceVisualList> drawList,
            Action<DrawNumber> numList1,
            Action<DrawNumber> numList2,
            Action<DrawNumber> numList3,
            Action<DrawNumber> numList4,
            Action<DrawNumber> numList5,
            Action<DrawNumber> numList6,
            Action<DrawNumber> numList7,
            Action<DrawNumber> numList8,
            Action<DrawNumber> numList9,
            Action<DrawNumber> numList10,
            Action<DrawNumber> numList11,
            Action<DrawNumber> numList12,
            Action<DrawNumber> numList13,
            Action<DrawNumber> numList14,
            Action<DrawNumber> numList15,
            Action<DrawNumber> numList16,
            Action<DrawNumber> numList17,
            Action<DrawNumber> numList18,
            Action<DrawNumber> numList19,
            Action<DrawNumber> numList20,
            Action<DrawNumber> numList21,
            Action<DrawNumber> numList22,
            Action<DrawNumber> numList23,
            Action<DrawNumber> numList24,
            Action<DrawNumber> numList25,
            Action<DrawNumber> numList26,
            Action<DrawNumber> numList27,
            Action<DrawNumber> numList28,
            Action<DrawNumber> numList29,
            Action<DrawNumber> numList30,
            Action<DrawNumber> numList31,
            Action<DrawNumber> numList32,
            Action<DrawNumber> numList33,
            Action<DrawNumber> numList34,
            Action<DrawNumber> numList35,
            Action<DrawNumber> numList36,
            Action<DrawNumber> numList37,
            Action<DrawNumber> numList38,
            Action<DrawNumber> numList39,
            Action<DrawNumber> numList40,
            Action<DrawNumber> numList41,
            Action<DrawNumber> numList42,
            Action<DrawNumber> numList43,
            Action<DrawNumber> numList44,
            Action<DrawNumber> numList45,
            Action<DrawNumber> numList46,
            Action<DrawNumber> numList47,
            Action<DrawNumber> numList48
            )
        {
            _PatternsIcon = PatternsIcon;
            _IsBusy = IsBusy;
            _PatternButtonIsEnabled = PatternButtonIsEnabled;
            _PatternProgressVisibility = PatternProgressVisibility;
            _DrawList = drawList;
            _NumList1 = numList1;
            _NumList2 = numList2;
            _NumList3 = numList3;
            _NumList4 = numList4;
            _NumList5 = numList5;
            _NumList6 = numList6;
            _NumList7 = numList7;
            _NumList8 = numList8;
            _NumList9 = numList9;
            _NumList10 = numList10;
            _NumList11 = numList11;
            _NumList12 = numList12;
            _NumList13 = numList13;
            _NumList14 = numList14;
            _NumList15 = numList15;
            _NumList16 = numList16;
            _NumList17 = numList17;
            _NumList18 = numList18;
            _NumList19 = numList19;
            _NumList20 = numList20;
            _NumList21 = numList21;
            _NumList22 = numList22;
            _NumList23 = numList23;
            _NumList24 = numList24;
            _NumList25 = numList25;
            _NumList26 = numList26;
            _NumList27 = numList27;
            _NumList28 = numList28;
            _NumList29 = numList29;
            _NumList30 = numList30;
            _NumList31 = numList31;
            _NumList32 = numList32;
            _NumList33 = numList33;
            _NumList34 = numList34;
            _NumList35 = numList35;
            _NumList36 = numList36;
            _NumList37 = numList37;
            _NumList38 = numList38;
            _NumList39 = numList39;
            _NumList40 = numList40;
            _NumList41 = numList41;
            _NumList42 = numList42;
            _NumList43 = numList43;
            _NumList44 = numList44;
            _NumList45 = numList45;
            _NumList46 = numList46;
            _NumList47 = numList47;
            _NumList48 = numList48; 
        }
        public async Task<ObservableCollection<DrawSequenceVisualList>> GeAllNumberPatternsListAsync(ObservableCollection<VikingLottoNumbers> lottoTask)
        {

            int[] numbers = new int[48];

            #region Populate numbers

            int indexCounter = 0;
            int numberCounter = 1;

            while (indexCounter < numbers.Length)
            {
                numbers[indexCounter] = numberCounter;

                indexCounter++;
                numberCounter++;
            }
            #endregion

            ObservableCollection<DrawSequenceVisualList> sequenceList = new ObservableCollection<DrawSequenceVisualList>();

            List<Task<DrawSequenceVisualList>> tasks = new List<Task<DrawSequenceVisualList>>();

            foreach (var num in numbers)
            {
                tasks.Add(Task.Run(() => GetOneNumberPatternListAsync(lottoTask, num)));
            }

            var result = await Task.WhenAll(tasks);

            foreach (var item in result)
            {
                sequenceList.Add(item);
            }

            return sequenceList;

        }
        private async Task<DrawSequenceVisualList> GetOneNumberPatternListAsync(ObservableCollection<VikingLottoNumbers> lottoTask, int num)
        {
            DrawSequenceVisualList sequenceVisualList = new DrawSequenceVisualList();
            sequenceVisualList.NumList = new List<DrawNumber>();

            int firstCountDetect = 0;
            int apearanceCounter = 0;
            int notDrawCounter = 0;

            List <Task<DrawNumber>> tasks = new List<Task<DrawNumber>>();

            foreach (var item in lottoTask)
            {
                firstCountDetect++;

                if (item.NumCollection.Contains(num))
                {
                    if (num < 10)
                    {
                        apearanceCounter++;
                        notDrawCounter = 0;
                    }
                    else
                    {
                        apearanceCounter++;
                        notDrawCounter = 0;
                    }

                }
                else
                {
                    notDrawCounter++;
                }

                CountersHolder countersHolder = new CountersHolder()
                {
                    FirstCountDetect = firstCountDetect,
                    ApearanceCounter = apearanceCounter,
                    NotDrawCounter = notDrawCounter
                };

                tasks.Add(Task.Run(() => GetNumberApearance(num, sequenceVisualList, countersHolder, item)));
            }

            var results = await Task.WhenAll(tasks);

            foreach (var item in results)
            {
                sequenceVisualList.NumList.Add(item);
            }

            return sequenceVisualList;
        }
        /// <summary>
        /// Add number visualisation
        /// </summary>
        /// <param name="num"></param>
        /// <param name="sequenceVisualList"></param>
        /// <param name="countersHolder"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        private static DrawNumber GetNumberApearance(int num, DrawSequenceVisualList sequenceVisualList, CountersHolder countersHolder, VikingLottoNumbers item)
        {
            DrawNumber drawNumber = new DrawNumber();
            if (item.NumCollection.Contains(num))
            {
                drawNumber.No = "Images/W_No/w" + num.ToString() + ".png";
            }
            else
            {
                drawNumber.No = "Images/No/" + countersHolder.NotDrawCounter.ToString() + ".png";
            }

            return drawNumber;
        }

        public async Task<ObservableCollection<DrawNumberAndAverage>> GetDrawNumbersAndAveragesAsync(ObservableCollection<VikingLottoNumbers> lottoTask)
        {

            ObservableCollection<DrawNumberAndAverage> drawNumberAndAverages = new ObservableCollection<DrawNumberAndAverage>();

            List<Task<DrawNumberAndAverage>> tasks = new List<Task<DrawNumberAndAverage>>();

            int couner = 1;

            while (couner<49)
            {
                CountersHolder countersHolder = new CountersHolder { Counter = couner };

                tasks.Add(Task.Run(() => GettingNumber(lottoTask, drawNumberAndAverages, countersHolder.Counter) ));

                couner++;
            }

            var result = await Task.WhenAll(tasks);

            foreach (var item in result)
            {
                drawNumberAndAverages.Add(item);
            }

            return drawNumberAndAverages;
        }

        private DrawNumberAndAverage GettingNumber(ObservableCollection<VikingLottoNumbers> lottoTask,
            ObservableCollection<DrawNumberAndAverage> drawNumberAndAverages,
            int couner)
        {
            var noRepeatsCount = lottoTask.Select(x => x.NumCollection).
           Where(x => x.Contains(couner)).Count();

            return new DrawNumberAndAverage
            {
                No = "Images/W_No/w" + couner.ToString() + ".png",
                Average = ((double)lottoTask.Count / noRepeatsCount).ToString("0.0")
            };

        }
        public static void PopulatePatterns()
        {
            Timer = new DispatcherTimer(DispatcherPriority.SystemIdle);
            Timer.Interval = TimeSpan.FromMilliseconds(1);
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            StopAddingItems(sender);
            AddItemsToPatternView(sender, _PatternButtonIsEnabled, _PatternProgressVisibility);
            StopAddingItems(sender);
            AddItemsToPatternView(sender, _PatternButtonIsEnabled, _PatternProgressVisibility);
            StopAddingItems(sender);
            AddItemsToPatternView(sender, _PatternButtonIsEnabled, _PatternProgressVisibility);
            StopAddingItems(sender);
            AddItemsToPatternView(sender, _PatternButtonIsEnabled, _PatternProgressVisibility);
            StopAddingItems(sender);
            AddItemsToPatternView(sender, _PatternButtonIsEnabled, _PatternProgressVisibility);
        }
        private static void StopAddingItems(object sender)
        {
            if (StopAdding)
            {
                DispatcherTimer senderTimer = (DispatcherTimer)sender;
                senderTimer.Stop();

                StopAdding = false;
            }
        }
        private static void AddItemsToPatternView(object sender, Action<bool> PatternButtonIsEnabled
            , Action<string> PatternProgressVisibility)
        {
            if (LotteryViewModel.NumCount < _DrawList.Count)
            {
                if (LotteryViewModel.TotalDraws < _DrawList[0].NumList.Count)
                {
                    NumListItemAdd(LotteryViewModel.NumCount, LotteryViewModel.TotalDraws);

                }
                else
                {
                    AllItemsAdded = true;

                    DispatcherTimer senderTimer = (DispatcherTimer)sender;
                    senderTimer.Stop();
                }
                LotteryViewModel.NumCount++;
            }
            else
            {
                LotteryViewModel.TotalDraws++;
                LotteryViewModel.NumCount = 0;
            }

            if (ButtonEnabled)
            {
                _IsBusy(false);
                _PatternsIcon(@"Images\Patterns Icon.png");

                PatternButtonIsEnabled(ButtonEnabled);
                PatternProgressVisibility("Hidden");

                ButtonEnabled = false;
            }

        }

        private static void NumListItemAdd(int numCount, int totalDraws)
        {
            switch (numCount)
            {
                case 0:
                    _NumList1(_DrawList[numCount].NumList[totalDraws]);
                    break;
                case 1:
                    _NumList2(_DrawList[numCount].NumList[totalDraws]);
                    break;
                case 2:
                    _NumList3(_DrawList[numCount].NumList[totalDraws]);
                    break;
                case 3:
                    _NumList4(_DrawList[numCount].NumList[totalDraws]);
                    break;
                case 4:
                    _NumList5(_DrawList[numCount].NumList[totalDraws]);
                    break;
                case 5:
                    _NumList6(_DrawList[numCount].NumList[totalDraws]);
                    break;
                case 6:
                    _NumList7(_DrawList[numCount].NumList[totalDraws]);
                    break;
                case 7:
                    _NumList8(_DrawList[numCount].NumList[totalDraws]);
                    break;
                case 8:
                    _NumList9(_DrawList[numCount].NumList[totalDraws]);
                    break;
                case 9:
                    _NumList10(_DrawList[numCount].NumList[totalDraws]);
                    break;
                case 10:
                    _NumList11(_DrawList[numCount].NumList[totalDraws]);
                    break;
                case 11:
                    _NumList12(_DrawList[numCount].NumList[totalDraws]);
                    break;
                case 12:
                    _NumList13(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 13:      
                    _NumList14(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 14:      
                    _NumList15(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 15:      
                    _NumList16(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 16:      
                    _NumList17(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 17:      
                    _NumList18(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 18:      
                    _NumList19(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 19:      
                    _NumList20(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 20:      
                    _NumList21(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 21:      
                    _NumList22(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 22:      
                    _NumList23(_DrawList[numCount].NumList[totalDraws]);
                    break;   
                case 23:     
                    _NumList24(_DrawList[numCount].NumList[totalDraws]);
                    break;   
                case 24:     
                    _NumList25(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 25:      
                    _NumList26(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 26:      
                    _NumList27(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 27:      
                    _NumList28(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 28:      
                    _NumList29(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 29:      
                    _NumList30(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 30:      
                    _NumList31(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 31:      
                    _NumList32(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 32:      
                    _NumList33(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 33:      
                    _NumList34(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 34:      
                    _NumList35(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 35:      
                    _NumList36(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 36:      
                    _NumList37(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 37:      
                    _NumList38(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 38:      
                    _NumList39(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 39:      
                    _NumList40(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 40:      
                    _NumList41(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 41:      
                    _NumList42(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 42:      
                    _NumList43(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 43:      
                    _NumList44(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 44:      
                    _NumList45(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 45:      
                    _NumList46(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 46:      
                    _NumList47(_DrawList[numCount].NumList[totalDraws]);
                    break;    
                case 47:     
                    _NumList48(_DrawList[numCount].NumList[totalDraws]);
                    break;
            }
        }
    }
}
