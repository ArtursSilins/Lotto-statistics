using HtmlAgilityPack;
using LiveCharts;
using LiveCharts.Wpf;
using LotteryNumCheck.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace LotteryNumCheck
{
    public class LotteryViewModel : ViewModelBase
    {

        public ICommand FindMatch { get; private set; }
        public ICommand TopSimilaritiesOpen { get; private set; }
        public ICommand TopSimilaritiesCloase { get; private set; }
        public ICommand NumberPatternsOpen { get; private set; }
        public ICommand NumberPatternsCloase { get; private set; }
        public ICommand HoverOnTopSimilatities { get; private set; }
        public ICommand HoverOfTopSimilatities { get; private set; }
        public ICommand HoverOnCloase { get; private set; }
        public ICommand HoverOfCloase { get; private set; }
        public ICommand HoverOnMinimize { get; private set; }
        public ICommand HoverOfMinimize { get; private set; }


        private ObservableCollection<VikingLottoNumbers> matchResults;

        public ObservableCollection<VikingLottoNumbers> MatchResults
        {
            get
            {

                return matchResults;
            }
            set
            {
                matchResults = value;
                OnPropertyChanged(nameof(MatchResults));
            }
        }

        private string wrongInputMessage;

        public string WrongInputMessage
        {
            get
            {
                return wrongInputMessage;
            }
            set
            {
                wrongInputMessage = value;
                OnPropertyChanged(nameof(WrongInputMessage));
            }
        }
        private string wrongInputMessageText;
        public string WrongInputMessageText
        {
            get
            {
                return wrongInputMessageText;
            }
            set
            {
                wrongInputMessageText = value;
                OnPropertyChanged(nameof(WrongInputMessageText));
            }
        }

        private string num1;

        public string Num1
        {
            get
            {
                return num1;
            }
            set
            {
                num1 = TestInput(value);
                OnPropertyChanged(nameof(Num1));
            }
        }
        private string num2;

        public string Num2
        {
            get
            {
                return num2;
            }
            set
            {
                num2 = TestInput(value);
                OnPropertyChanged(nameof(Num2));
            }
        }
        private string num3;

        public string Num3
        {
            get
            {
                return num3;
            }
            set
            {
                num3 = TestInput(value);
                OnPropertyChanged(nameof(Num3));
            }
        }
        private string num4;
        public string Num4
        {
            get
            {
                return num4;
            }
            set
            {
                num4 = TestInput(value);
                OnPropertyChanged(nameof(Num4));
            }
        }
        private string num5;
        public string Num5
        {
            get
            {
                return num5;
            }
            set
            {
                num5 = TestInput(value);
                OnPropertyChanged(nameof(Num5));
            }
        }
        private string num6;
        public string Num6
        {
            get
            {
                return num6;
            }
            set
            {
                num6 = TestInput(value);
                OnPropertyChanged(nameof(Num6));
            }
        }
        private string additionalNum;
        public string AdditionalNum
        {
            get
            {
                return additionalNum;
            }
            set
            {
                additionalNum = TestInput(value);
                OnPropertyChanged(nameof(AdditionalNum));
            }
        }

        private string minCountOfMatch;
        public string MinCountOfMatch
        {
            get
            {
                return minCountOfMatch;
            }
            set
            {
                minCountOfMatch = TestInput(value);
                OnPropertyChanged(nameof(MinCountOfMatch));
            }
        }

        #region Moust frekuently drawn column properties

        private ObservableCollection<SpecificNumberAndRepeat> num1List;

        public ObservableCollection<SpecificNumberAndRepeat> Num1List
        {
            get
            {
                return num1List;
            }
            set
            {
                num1List = value;
                OnPropertyChanged(nameof(Num1List));
            }
        }
        private ObservableCollection<SpecificNumberAndRepeat> num2List;

        public ObservableCollection<SpecificNumberAndRepeat> Num2List
        {
            get
            {
                return num2List;
            }
            set
            {
                num2List = value;
                OnPropertyChanged(nameof(Num2List));
            }
        }
        private ObservableCollection<SpecificNumberAndRepeat> num3List;

        public ObservableCollection<SpecificNumberAndRepeat> Num3List
        {
            get
            {
                return num3List;
            }
            set
            {
                num3List = value;
                OnPropertyChanged(nameof(Num3List));
            }
        }
        private ObservableCollection<SpecificNumberAndRepeat> num4List;

        public ObservableCollection<SpecificNumberAndRepeat> Num4List
        {
            get
            {
                return num4List;
            }
            set
            {
                num4List = value;
                OnPropertyChanged(nameof(Num4List));
            }
        }
        private ObservableCollection<SpecificNumberAndRepeat> num5List;

        public ObservableCollection<SpecificNumberAndRepeat> Num5List
        {
            get
            {
                return num5List;
            }
            set
            {
                num5List = value;
                OnPropertyChanged(nameof(Num5List));
            }
        }
        private ObservableCollection<SpecificNumberAndRepeat> num6List;

        public ObservableCollection<SpecificNumberAndRepeat> Num6List
        {
            get
            {
                return num6List;
            }
            set
            {
                num6List = value;
                OnPropertyChanged(nameof(Num6List));
            }
        }

        private ObservableCollection<SpecificNumberAndRepeat> additionalNumList;

        public ObservableCollection<SpecificNumberAndRepeat> AdditionalNumList
        {
            get
            {
                return additionalNumList;
            }
            set
            {
                additionalNumList = value;
                OnPropertyChanged(nameof(AdditionalNumList));
            }
        }

        #endregion

        private ObservableCollection<VikingLottoNumbers> allNumbersList;

        public ObservableCollection<VikingLottoNumbers> AllNumbersList
        {
            get { return allNumbersList; }
            set
            {
                allNumbersList = value;
                OnPropertyChanged(nameof(AllNumbersList));
            }
        }

        #region LastDrawResult

        private int lastWinNum1;

        public int LastWinNum1
        {
            get
            {
                return lastWinNum1;
            }
            set
            {
                lastWinNum1 = value;
                OnPropertyChanged(nameof(LastWinNum1));
            }
        }
        private int lastWinNum2;

        public int LastWinNum2
        {
            get
            {
                return lastWinNum2;
            }
            set
            {
                lastWinNum2 = value;
                OnPropertyChanged(nameof(LastWinNum2));
            }
        }
        private int lastWinNum3;

        public int LastWinNum3
        {
            get
            {
                return lastWinNum3;
            }
            set
            {
                lastWinNum3 = value;
                OnPropertyChanged(nameof(LastWinNum3));
            }
        }
        private int lastWinNum4;

        public int LastWinNum4
        {
            get
            {
                return lastWinNum4;
            }
            set
            {
                lastWinNum4 = value;
                OnPropertyChanged(nameof(LastWinNum4));
            }
        }
        private int lastWinNum5;

        public int LastWinNum5
        {
            get
            {
                return lastWinNum5;
            }
            set
            {
                lastWinNum5 = value;
                OnPropertyChanged(nameof(LastWinNum5));
            }
        }
        private int lastWinNum6;

        public int LastWinNum6
        {
            get
            {
                return lastWinNum6;
            }
            set
            {
                lastWinNum6 = value;
                OnPropertyChanged(nameof(LastWinNum6));
            }
        }
        private int lastWinAdditionalNum;
        public int LastWinAdditionalNum
        {
            get
            {
                return lastWinAdditionalNum;
            }
            set
            {
                lastWinAdditionalNum = value;
                OnPropertyChanged(nameof(LastWinAdditionalNum));
            }
        }

        #endregion

        private ObservableCollection<SimilarityHolderViewModel> similarityHolderViews;

        public ObservableCollection<SimilarityHolderViewModel> SimilarityHolderViews
        {
            get
            {
                return similarityHolderViews;
            }
            set
            {
                similarityHolderViews = value;
                OnPropertyChanged(nameof(SimilarityHolderViews));
            }
        }
        private ObservableCollection<WinNumbersList> winResultList;

        public ObservableCollection<WinNumbersList> WinResultList
        {
            get
            {
                return winResultList;
            }
            set
            {
                winResultList = value;
                OnPropertyChanged(nameof(WinResultList));
            }
        }
        private bool enableButton;

        public bool EnableButton
        {
            get
            {
                return enableButton;
            }
            set
            {
                enableButton = value;
                OnPropertyChanged(nameof(EnableButton));
            }
        }

        #region PopupBuble Properties

        private string topSimilaritiesVisibility;

        public string TopSimilaritiesVisibility
        {
            get { return topSimilaritiesVisibility; }
            set
            {
                topSimilaritiesVisibility = value;
                OnPropertyChanged(nameof(TopSimilaritiesVisibility));
            }
        }
        private string topSimilaritiesCloaseVisibility;

        public string TopSimilaritiesCloaseVisibility
        {
            get { return topSimilaritiesCloaseVisibility; }
            set
            {
                topSimilaritiesCloaseVisibility = value;
                OnPropertyChanged(nameof(TopSimilaritiesCloaseVisibility));
            }
        }

        private string numberPatternsVisibility;

        public string NumberPatternsVisibility
        {
            get { return numberPatternsVisibility; }
            set
            {
                numberPatternsVisibility = value;
                OnPropertyChanged(nameof(NumberPatternsVisibility));
            }
        }
        private string numberPatternsCloaseVisibility;
        public string NumberPatternsCloaseVisibility
        {
            get { return numberPatternsCloaseVisibility; }
            set
            {
                numberPatternsCloaseVisibility = value;
                OnPropertyChanged(nameof(NumberPatternsCloaseVisibility));
            }
        }


        private string topSimilaritiesPopupBuble;

        public string TopSimilaritiesPopupBuble
        {
            get { return topSimilaritiesPopupBuble; }
            set
            {
                topSimilaritiesPopupBuble = value;
                OnPropertyChanged(nameof(TopSimilaritiesPopupBuble));
            }
        }

        private string cloasePopupBuble;

        public string CloasePopupBuble
        {
            get { return cloasePopupBuble; }
            set
            {
                cloasePopupBuble = value;
                OnPropertyChanged(nameof(CloasePopupBuble));
            }
        }

        private string minimizePopupBuble;

        public string MinimizePopupBuble
        {
            get { return minimizePopupBuble; }
            set
            {
                minimizePopupBuble = value;
                OnPropertyChanged(nameof(MinimizePopupBuble));
            }
        }

        private string popupBubleText;

        public string PopupBubleText
        {
            get { return popupBubleText; }
            set
            {
                popupBubleText = value;
                OnPropertyChanged(nameof(PopupBubleText));
            }
        }
        private string popupBubleBottomPlacement;

        public string PopupBubleBottomPlacement
        {
            get { return popupBubleBottomPlacement; }
            set
            {
                popupBubleBottomPlacement = value;
                OnPropertyChanged(nameof(PopupBubleBottomPlacement));
            }
        }
        private string popupBubleTopPlacement;

        public string PopupBubleTopPlacement
        {
            get { return popupBubleTopPlacement; }
            set
            {
                popupBubleTopPlacement = value;
                OnPropertyChanged(nameof(PopupBubleTopPlacement));
            }
        }

        private string popupBottomVisibility;

        public string PopupBottomVisibility
        {
            get { return popupBottomVisibility; }
            set
            {
                popupBottomVisibility = value;
                OnPropertyChanged(nameof(PopupBottomVisibility));
            }
        }

        private string popupTopVisibility;

        public string PopupTopVisibility
        {
            get { return popupTopVisibility; }
            set
            {
                popupTopVisibility = value;
                OnPropertyChanged(nameof(PopupTopVisibility));
            }
        }

        #endregion

        private string progressBarVisibility;
        public string ProgressBarVisibility
        {
            get
            {
                return progressBarVisibility;
            }
            set
            {
                progressBarVisibility = value;
                OnPropertyChanged(nameof(ProgressBarVisibility));
            }
        }
        private int progressValue;
        public int ProgressValue
        {
            get
            {
                return progressValue;
            }
            set
            {
                progressValue = value;
                OnPropertyChanged(nameof(ProgressValue));
            }
        }

        private ObservableCollection<DrawSequenceVisualList> sequenceVisualList;

        public ObservableCollection<DrawSequenceVisualList> SequenceVisualList
        {
            get
            {
                return sequenceVisualList;
            }
            set
            {
                sequenceVisualList = value;
                OnPropertyChanged(nameof(SequenceVisualList));
            }
        }

        private string drawVisual;

        public string DrawVisual
        {
            get { return drawVisual; }
            set
            {
                drawVisual = value;
                OnPropertyChanged(nameof(DrawVisual));
            }
        }


        private ObservableCollection<VikingLottoNumbers> lottoTask { get; set; }

        private static DispatcherTimer Timer { get; set; }
        private static int TimerTickCounter { get; set; }
        public LotteryViewModel()
        {
            EnableButton = false;

            CloasePopupBuble = "Hidden";
            TopSimilaritiesPopupBuble = "Hidden";
            MinimizePopupBuble = "Hidden";
            ProgressBarVisibility = "Visible";

            WrongInputMessage = "Hidden";

            TopSimilaritiesOpen = new RelayCommand(TopSimilaritiesOpenHidden);
            TopSimilaritiesCloase = new RelayCommand(TopSimilaritiesCloaseHidden);

            NumberPatternsOpen = new RelayCommand(NumberPatternsOpenHidden);
            NumberPatternsCloase = new RelayCommand(NumberPatternsCloaseHidden);

            HoverOnTopSimilatities = new RelayCommand(MouseOver);
            HoverOfTopSimilatities = new RelayCommand(MouseLeave);

            HoverOnCloase = new RelayCommand(MouseOverCloase);
            HoverOfCloase = new RelayCommand(MouseLeaveCloase);

            HoverOnMinimize = new RelayCommand(MouseOverMinimize);
            HoverOfMinimize = new RelayCommand(MouseLeaveMinimize);

            NumberDownloader numberDownloader = new NumberDownloader();

            numberDownloader.CachConnectionFail += NumberDownloader_CachConnectionFail;

            SimilarityHolder.FirstLoop = true;

            Progress<int> ProgressValue = new Progress<int>();
            ProgressValue.ProgressChanged += ProgressValue_ProgressChanged;

            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromSeconds(1);
            Timer.Tick += Timer_Tick;

            AllNumbersListGetter(numberDownloader.GetAllNumbersParalelAsync(ProgressValue), ProgressValue).ContinueWith((task) => { AllNumbersList = task.Result; });

            FindMatch = new RelayCommand(StartCalculations);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimerTickCounter++;

            if (TimerTickCounter == 2)
            {
                ProgressBarVisibility = "Hidden";
                Timer.Stop();
            }

        }

        private void ProgressValue_ProgressChanged(object sender, int e)
        {
            if (!NumberDownloaderProgressGetter.IsEnd)
                ProgressValue = e;
            else
                ProgressValue += e;

            if (ProgressValue == 100 && !NumberDownloaderProgressGetter.IsEnd)
            {
                NumberDownloaderProgressGetter.IsEnd = true;
                ProgressValue = 0;
            }
            else if (ProgressValue == 100 && NumberDownloaderProgressGetter.IsEnd)
            {
                Timer.Start();
            }
        }

        private void NumberDownloader_CachConnectionFail(object sender, bool e)
        {
            WrongInputMessageText = "No Network Connectin.";
            WrongInputMessage = "Visible";
        }

        #region PpupBuble Methods
        private void MouseLeaveMinimize()
        {
            MinimizePopupBuble = "Hidden";
        }

        private void MouseOverMinimize()
        {
            PopupBubleTopPlacement = "Right";
            PopupTopVisibility = "Visible";
            PopupBottomVisibility = "Hidden";
            PopupBubleText = "Minimize";
            MinimizePopupBuble = "Visible";
        }

        private void MouseLeaveCloase()
        {
            CloasePopupBuble = "Hidden";
        }

        private void MouseOverCloase()
        {
            PopupBubleTopPlacement = "Right";
            PopupTopVisibility = "Visible";
            PopupBottomVisibility = "Hidden";
            PopupBubleText = "Cloase";
            CloasePopupBuble = "Visible";
        }

        private void MouseLeave()
        {
            TopSimilaritiesPopupBuble = "Hidden";
        }

        private void MouseOver()
        {
            PopupBubleBottomPlacement = "Right";
            PopupTopVisibility = "Hidden";
            PopupBottomVisibility = "Visible";
            PopupBubleText = "Top Matches";
            TopSimilaritiesPopupBuble = "Visible";
        }

        private void TopSimilaritiesOpenHidden()
        {
            TopSimilaritiesVisibility = "Hidden";
            TopSimilaritiesCloaseVisibility = "Visible";
        }
        private void TopSimilaritiesCloaseHidden()
        {
            TopSimilaritiesCloaseVisibility = "Hidden";
            TopSimilaritiesVisibility = "Visible";
        }
        private void NumberPatternsOpenHidden()
        {
            NumberPatternsVisibility = "hidden";
            NumberPatternsCloaseVisibility = "visible";
        }
        private void NumberPatternsCloaseHidden()
        {
            NumberPatternsCloaseVisibility = "hidden";
            NumberPatternsVisibility = "visible";
        }
        #endregion

        private bool DigitCheck(string value)
        {
            bool isNumeric = int.TryParse(value, out _);
            return isNumeric;
        }

        private void StartCalculations()
        {

            if (Num1 != null && Num1 != "" && Num2 != null && Num2 != "" && Num3 != null && Num3 != "" &&
                Num4 != null && Num4 != "" && Num5 != null && Num5 != "" && Num6 != null && Num6 != "" &&
                AdditionalNum != null && AdditionalNum != "" && MinCountOfMatch != null && MinCountOfMatch != "")
            {
                WrongInputMessage = "Hidden";

                MatchResults = null;

                MatchResults = FindMatchInResults.GetSimilarities(Convert.ToInt16(Num1), Convert.ToInt16(Num2), Convert.ToInt16(Num3),
                    Convert.ToInt16(Num4), Convert.ToInt16(Num5), Convert.ToInt16(Num6),
                    Convert.ToInt16(AdditionalNum), AllNumbersList, Convert.ToInt16(MinCountOfMatch));
            }
            else
            {
                WrongInputMessage = "Visible";
                WrongInputMessageText = "Wrong Input or \nan input field is empty!";
            }


            if (Num1 != null && Num1 != "" && Num2 != null && Num2 != "" && Num3 != null && Num3 != "" &&
                Num4 != null && Num4 != "" && Num5 != null && Num5 != "" && Num6 != null && Num6 != "" &&
                AdditionalNum != null && AdditionalNum != "" && MinCountOfMatch != null && MinCountOfMatch != "" && MatchResults.Count == 0)
            {
                WrongInputMessage = "Visible";
                WrongInputMessageText = "No result found!";
            }


        }

        private string TestInput(string value)
        {
            if (DigitCheck(value))
            {
                WrongInputMessage = "Hidden";
                return value;
            }
            else
            {
                MatchResults?.Clear();
                WrongInputMessage = "Visible";
                value = "";
                return value;
            }

        }

        private void AddLastWinNumbers(ObservableCollection<VikingLottoNumbers> vikingLottoNumbers, IProgress<int> progress)
        {
            LastWinNum1 = vikingLottoNumbers[0].Num1;
            LastWinNum2 = vikingLottoNumbers[0].Num2;
            LastWinNum3 = vikingLottoNumbers[0].Num3;
            LastWinNum4 = vikingLottoNumbers[0].Num4;
            LastWinNum5 = vikingLottoNumbers[0].Num5;
            LastWinNum6 = vikingLottoNumbers[0].Num6;
            LastWinAdditionalNum = vikingLottoNumbers[0].AdditionalNum;

            progress.Report(10);
        }
        public async Task<ObservableCollection<VikingLottoNumbers>> AllNumbersListGetter(Task<ObservableCollection<VikingLottoNumbers>> vikingLottoNumbers, IProgress<int> progress)
        {
            lottoTask = await vikingLottoNumbers;

            PrintAverage(lottoTask);
            /////////////// Free LiveChatr version (Bad performance)!!! //////////////
            /////
            ////SeriesCollection = await LiveChart.FindFrekvences(lottoTask);
            //////////////////////////

            AddLastWinNumbers(lottoTask, progress);

            List<Task<ObservableCollection<SpecificNumberAndRepeat>>> numbersAndRepeatTask = new List<Task<ObservableCollection<SpecificNumberAndRepeat>>>();

            int Counter = 1;

            while (Counter < 8)
            {
                SpecificNumberList specificNumberList = new SpecificNumberList();
                numbersAndRepeatTask.Add(specificNumberList.AddTopNumbersToColumns(lottoTask, Counter, progress));

                Counter++;
            }

            var result = await Task.WhenAll(numbersAndRepeatTask);

            int count = 0;

            foreach (var item in result)
            {
                switch (count)
                {
                    case 0:
                        Num1List = item;
                        break;
                    case 1:
                        Num2List = item;
                        break;
                    case 2:
                        Num3List = item;
                        break;
                    case 3:
                        Num4List = item;
                        break;
                    case 4:
                        Num5List = item;
                        break;
                    case 5:
                        Num6List = item;
                        break;
                    case 6:
                        AdditionalNumList = item;
                        break;
                }
                count++;
            }

            SimilarityHolderViews = SimilarityHolder.FindBestNumbers(lottoTask, 2, 5);

            WinResultList = await WinNumbersList.PopulateWinResultList(lottoTask, WinResultList, progress);

            EnableButton = true;

            return lottoTask;
        }

        private void PrintAverage(ObservableCollection<VikingLottoNumbers> lottoTask)
        {
            int[] numbers = new int[48];

            int indexCounter = 0;
            int numberCounter = 1;
            int apearanceCounter = 0;

            //int drowCount = 0;

            string text = "";

            while (indexCounter < numbers.Length)
            {
                numbers[indexCounter] = numberCounter;

                indexCounter++;
                numberCounter++;
            }

            foreach (var num in numbers)
            {
                //drowCount = 0;

                foreach (var item in lottoTask)
                {
                    if (item.NumCollection.Contains(num))
                    {
                        if (num < 10)
                        {
                            text += num.ToString() + " ";
                            apearanceCounter++;
                        }
                        else
                        {
                            text += num.ToString();
                            apearanceCounter++;
                        }


                        //text += " [" + drowCount + "] ";
                        //drawCount = 0;
                    }
                    else
                    {
                        text += "-";
                    }
                    //drowCount++;
                }

                text += " Average: " + (Convert.ToDouble(lottoTask.Count) / Convert.ToDouble(apearanceCounter)).ToString("0.00") + Environment.NewLine/* + Environment.NewLine*/;

                apearanceCounter = 0;
            }

            text += Environment.NewLine + " Total Times " + lottoTask.Count.ToString();

            foreach (var item in lottoTask)
            {
                int summ = 0;

                foreach (var num in item.NumCollection)
                {
                    summ += num;
                }

                text += Environment.NewLine;

                text += summ.ToString() + Environment.NewLine;

            }

            DrawVisual = text;

            DrawNumber drawNumber = new DrawNumber();
            drawNumber.Num = 1;

            DrawNumber drawNumber1 = new DrawNumber();
            drawNumber1.Num = 1;

            DrawSequenceVisualList sequenceVisualList1 = new DrawSequenceVisualList();

            sequenceVisualList1.NumList = new List<DrawNumber>();

            sequenceVisualList1.NumList.Add(drawNumber);
            sequenceVisualList1.NumList.Add(drawNumber1);

            SequenceVisualList = new ObservableCollection<DrawSequenceVisualList>();
            SequenceVisualList.Add(sequenceVisualList1);

        }

    }
}
