using HtmlAgilityPack;
using LotteryCore.Commands;
using LotteryCore.NoPatterns;
using LotteryCorer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;

namespace LotteryCore
{
    public class LotteryViewModel : ViewModelBase
    {

        public ICommand FindMatch { get; private set; }
        public ICommand TopSimilaritiesOpen { get; private set; }
        public ICommand TopSimilaritiesClose { get; private set; }
        public ICommand NumberPatternsOpen { get; private set; }
        public ICommand NumberPatternsClose { get; private set; }
        public ICommand HoverOnTopSimilatities { get; private set; }
        public ICommand HoverOfTopSimilatities { get; private set; }
        public ICommand HoverOnNumberPatterns { get; private set; }
        public ICommand HoverOfNumberPatterns { get; private set; }
        public ICommand HoverOnClose { get; private set; }
        public ICommand HoverOfClose { get; private set; }
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

        private ObservableCollection<ColumnNumbersAndRepeats> num1List;

        public ObservableCollection<ColumnNumbersAndRepeats> Num1List
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
        private ObservableCollection<ColumnNumbersAndRepeats> num2List;

        public ObservableCollection<ColumnNumbersAndRepeats> Num2List
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
        private ObservableCollection<ColumnNumbersAndRepeats> num3List;

        public ObservableCollection<ColumnNumbersAndRepeats> Num3List
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
        private ObservableCollection<ColumnNumbersAndRepeats> num4List;

        public ObservableCollection<ColumnNumbersAndRepeats> Num4List
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
        private ObservableCollection<ColumnNumbersAndRepeats> num5List;

        public ObservableCollection<ColumnNumbersAndRepeats> Num5List
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
        private ObservableCollection<ColumnNumbersAndRepeats> num6List;

        public ObservableCollection<ColumnNumbersAndRepeats> Num6List
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

        private ObservableCollection<ColumnNumbersAndRepeats> additionalNumList;

        public ObservableCollection<ColumnNumbersAndRepeats> AdditionalNumList
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
        private string topSimilaritiesCloseVisibility;

        public string TopSimilaritiesCloseVisibility
        {
            get { return topSimilaritiesCloseVisibility; }
            set
            {
                topSimilaritiesCloseVisibility = value;
                OnPropertyChanged(nameof(TopSimilaritiesCloseVisibility));
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
        private string numberPatternsCloseVisibility;
        public string NumberPatternsCloseVisibility
        {
            get { return numberPatternsCloseVisibility; }
            set
            {
                numberPatternsCloseVisibility = value;
                OnPropertyChanged(nameof(NumberPatternsCloseVisibility));
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

        private string drawSequenceVisualPopupBuble;

        public string DrawSequenceVisualPopupBuble
        {
            get { return drawSequenceVisualPopupBuble; }
            set
            {
                drawSequenceVisualPopupBuble = value;
                OnPropertyChanged(nameof(DrawSequenceVisualPopupBuble));
            }
        }


        private string closePopupBuble;

        public string ClosePopupBuble
        {
            get { return closePopupBuble; }
            set
            {
                closePopupBuble = value;
                OnPropertyChanged(nameof(ClosePopupBuble));
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

        private bool isBusy;

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged(nameof(IsBusy));
            }
        }

        private int patternProgress;
        public int PatternProgress
        {
            get
            {
                return patternProgress;
            }
            set
            {
                patternProgress = value;
                OnPropertyChanged(nameof(PatternProgress));
            }
        }

        private string patternProgressVisibility;

        public string PatternProgressVisibility
        {
            get { return patternProgressVisibility; }
            set
            {
                patternProgressVisibility = value;
                OnPropertyChanged(nameof(PatternProgressVisibility));
            }
        }

        private bool patternButtonIsEnabled;

        public bool PatternButtonIsEnabled
        {
            get { return patternButtonIsEnabled; }
            set
            {
                patternButtonIsEnabled = value;
                OnPropertyChanged(nameof(PatternButtonIsEnabled));
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

        private object _sequenceVisualListLock = new object();

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


        private ObservableCollection<VikingLottoNumbers> LottoTask { get; set; }

        private static DispatcherTimer Timer { get; set; }
        private static DispatcherTimer Timer2 { get; set; }

        private static DispatcherTimer TimerNumbersAndAverages { get; set; }
        private static ObservableCollection<DrawNumberAndAverage> NumberAndAverageHolder { get; set; }
        private static int NumberAndAverageCounter { get; set; }

        private static DispatcherTimer Timer3 { get; set; }
        public int Timer3Count { get; set; }
        private ObservableCollection<ColumnNumbersAndRepeats>[] NumberColumnResults { get; set; }

        private static DispatcherTimer Timer4 { get; set; }
        private static ObservableCollection<WinNumbersList> WinNumbersListsHolder { get; set; }
        private static int WinResultListCounter { get; set; }

        delegate void Num_List_Item_Add(int numCount, int totalDraws);

        public ObservableCollection<DrawSequenceVisualList> DrawList { get; set; }

        private ObservableCollection<DrawNumber>[] drawNumbers;

        public ObservableCollection<DrawNumber>[] DrawNumbers
        {
            get { return drawNumbers; }
            set
            {
                drawNumbers = value;
                OnPropertyChanged(nameof(DrawNumbers));
            }
        }

        #region PatternVisual

        private ObservableCollection<DrawNumberAndAverage> numberAndAverageTitle;

        public ObservableCollection<DrawNumberAndAverage> NumberAndAverageTitle
        {
            get { return numberAndAverageTitle; }
            set
            {
                numberAndAverageTitle = value;
                OnPropertyChanged(nameof(NumberAndAverageTitle));
            }
        }


        private ObservableCollection<DrawNumber> numList1 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList1
        {
            get
            {
                return numList1;
            }
            set
            {
                numList1 = value;
                OnPropertyChanged(nameof(NumList1));
            }
        }
        private ObservableCollection<DrawNumber> numList2 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList2
        {
            get { return numList2; }
            set
            {
                numList2 = value;
                OnPropertyChanged(nameof(NumList2));
            }
        }
        private ObservableCollection<DrawNumber> numList3 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList3
        {
            get{ return numList3; }
            set
            {
                numList3 = value;
                OnPropertyChanged(nameof(NumList3));
            }
        }
        private ObservableCollection<DrawNumber> numList4 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList4
        {
            get { return numList4; }
            set
            {
                numList4 = value;
                OnPropertyChanged(nameof(NumList4));
            }
        }
        private ObservableCollection<DrawNumber> numList5 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList5
        {
            get { return numList5; }
            set
            {
                numList5 = value;
                OnPropertyChanged(nameof(NumList5));
            }
        }
        private ObservableCollection<DrawNumber> numList6 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList6
        {
            get
            {
                return numList6;
            }
            set
            {
                numList6 = value;
                OnPropertyChanged(nameof(NumList6));
            }
        }
        private ObservableCollection<DrawNumber> numList7 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList7
        {
            get { return numList7; }
            set
            {
                numList7 = value;
                OnPropertyChanged(nameof(NumList7));
            }
        }
        private ObservableCollection<DrawNumber> numList8 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList8
        {
            get { return numList8; }
            set
            {
                numList8 = value;
                OnPropertyChanged(nameof(NumList8));
            }
        }
        private ObservableCollection<DrawNumber> numList9 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList9
        {
            get { return numList9; }
            set
            {
                numList9 = value;
                OnPropertyChanged(nameof(NumList9));
            }
        }
        private ObservableCollection<DrawNumber> numList10 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList10
        {
            get { return numList10; }
            set
            {
                numList10 = value;
                OnPropertyChanged(nameof(NumList10));
            }
        }
        private ObservableCollection<DrawNumber> numList11 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList11
        {
            get { return numList11; }
            set
            {
                numList11 = value;
                OnPropertyChanged(nameof(NumList11));
            }
        }
        private ObservableCollection<DrawNumber> numList12 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList12
        {
            get { return numList12; }
            set
            {
                numList12 = value;
                OnPropertyChanged(nameof(NumList12));
            }
        }
        private ObservableCollection<DrawNumber> numList13 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList13
        {
            get { return numList13; }
            set
            {
                numList13 = value;
                OnPropertyChanged(nameof(NumList13));
            }
        }
        private ObservableCollection<DrawNumber> numList14 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList14
        {
            get { return numList14; }
            set
            {
                numList14 = value;
                OnPropertyChanged(nameof(NumList14));
            }
        }
        private ObservableCollection<DrawNumber> numList15 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList15
        {
            get { return numList15; }
            set
            {
                numList15 = value;
                OnPropertyChanged(nameof(NumList15));
            }
        }
        private ObservableCollection<DrawNumber> numList16 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList16
        {
            get { return numList16; }
            set
            {
                numList16 = value;
                OnPropertyChanged(nameof(NumList16));
            }
        }
        private ObservableCollection<DrawNumber> numList17 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList17
        {
            get { return numList17; }
            set
            {
                numList17 = value;
                OnPropertyChanged(nameof(NumList17));
            }
        }
        private ObservableCollection<DrawNumber> numList18 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList18
        {
            get { return numList18; }
            set
            {
                numList18 = value;
                OnPropertyChanged(nameof(NumList18));
            }
        }
        private ObservableCollection<DrawNumber> numList19 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList19
        {
            get { return numList19; }
            set
            {
                numList19 = value;
                OnPropertyChanged(nameof(NumList19));
            }
        }
        private ObservableCollection<DrawNumber> numList20 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList20
        {
            get { return numList20; }
            set
            {
                numList20 = value;
                OnPropertyChanged(nameof(NumList20));
            }
        }
        private ObservableCollection<DrawNumber> numList21 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList21
        {
            get { return numList21; }
            set
            {
                numList21 = value;
                OnPropertyChanged(nameof(NumList21));
            }
        }
        private ObservableCollection<DrawNumber> numList22 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList22
        {
            get { return numList22; }
            set
            {
                numList22 = value;
                OnPropertyChanged(nameof(NumList22));
            }
        }
        private ObservableCollection<DrawNumber> numList23 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList23
        {
            get { return numList23; }
            set
            {
                numList23 = value;
                OnPropertyChanged(nameof(NumList23));
            }
        }
        private ObservableCollection<DrawNumber> numList24 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList24
        {
            get { return numList24; }
            set
            {
                numList24 = value;
                OnPropertyChanged(nameof(NumList24));
            }
        }
        private ObservableCollection<DrawNumber> numList25 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList25
        {
            get { return numList25; }
            set
            {
                numList25 = value;
                OnPropertyChanged(nameof(NumList25));
            }
        }
        private ObservableCollection<DrawNumber> numList26 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList26
        {
            get { return numList26; }
            set
            {
                numList26 = value;
                OnPropertyChanged(nameof(NumList26));
            }
        }
        private ObservableCollection<DrawNumber> numList27 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList27
        {
            get { return numList27; }
            set
            {
                numList27 = value;
                OnPropertyChanged(nameof(NumList27));
            }
        }
        private ObservableCollection<DrawNumber> numList28 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList28
        {
            get { return numList28; }
            set
            {
                numList28 = value;
                OnPropertyChanged(nameof(NumList28));
            }
        }
        private ObservableCollection<DrawNumber> numList29 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList29
        {
            get { return numList29; }
            set
            {
                numList29 = value;
                OnPropertyChanged(nameof(NumList29));
            }
        }
        private ObservableCollection<DrawNumber> numList30 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList30
        {
            get { return numList30; }
            set
            {
                numList30 = value;
                OnPropertyChanged(nameof(NumList30));
            }
        }
        private ObservableCollection<DrawNumber> numList31 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList31
        {
            get { return numList31; }
            set
            {
                numList31 = value;
                OnPropertyChanged(nameof(NumList31));
            }
        }
        private ObservableCollection<DrawNumber> numList32 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList32
        {
            get { return numList32; }
            set
            {
                numList32 = value;
                OnPropertyChanged(nameof(NumList32));
            }
        }
        private ObservableCollection<DrawNumber> numList33 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList33
        {
            get { return numList33; }
            set
            {
                numList33 = value;
                OnPropertyChanged(nameof(NumList33));
            }
        }
        private ObservableCollection<DrawNumber> numList34 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList34
        {
            get { return numList34; }
            set
            {
                numList34 = value;
                OnPropertyChanged(nameof(NumList34));
            }
        }
        private ObservableCollection<DrawNumber> numList35 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList35
        {
            get { return numList35; }
            set
            {
                numList35 = value;
                OnPropertyChanged(nameof(NumList35));
            }
        }
        private ObservableCollection<DrawNumber> numList36 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList36
        {
            get { return numList36; }
            set
            {
                numList36 = value;
                OnPropertyChanged(nameof(NumList36));
            }
        }
        private ObservableCollection<DrawNumber> numList37 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList37
        {
            get { return numList37; }
            set
            {
                numList37 = value;
                OnPropertyChanged(nameof(NumList37));
            }
        }
        private ObservableCollection<DrawNumber> numList38 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList38
        {
            get { return numList38; }
            set
            {
                numList38 = value;
                OnPropertyChanged(nameof(NumList38));
            }
        }
        private ObservableCollection<DrawNumber> numList39 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList39
        {
            get { return numList39; }
            set
            {
                numList39 = value;
                OnPropertyChanged(nameof(NumList39));
            }
        }
        private ObservableCollection<DrawNumber> numList40 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList40
        {
            get { return numList40; }
            set
            {
                numList40 = value;
                OnPropertyChanged(nameof(NumList40));
            }
        }
        private ObservableCollection<DrawNumber> numList41 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList41
        {
            get { return numList41; }
            set
            {
                numList41 = value;
                OnPropertyChanged(nameof(NumList41));
            }
        }
        private ObservableCollection<DrawNumber> numList42 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList42
        {
            get { return numList42; }
            set
            {
                numList42 = value;
                OnPropertyChanged(nameof(NumList42));
            }
        }
        private ObservableCollection<DrawNumber> numList43 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList43
        {
            get { return numList43; }
            set
            {
                numList43 = value;
                OnPropertyChanged(nameof(NumList43));
            }
        }
        private ObservableCollection<DrawNumber> numList44 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList44
        {
            get { return numList44; }
            set
            {
                numList44 = value;
                OnPropertyChanged(nameof(NumList44));
            }
        }
        private ObservableCollection<DrawNumber> numList45 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList45
        {
            get { return numList45; }
            set
            {
                numList45 = value;
                OnPropertyChanged(nameof(NumList45));
            }
        }
        private ObservableCollection<DrawNumber> numList46 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList46
        {
            get { return numList46; }
            set
            {
                numList46 = value;
                OnPropertyChanged(nameof(NumList46));
            }
        }
        private ObservableCollection<DrawNumber> numList47 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList47
        {
            get { return numList47; }
            set
            {
                numList47 = value;
                OnPropertyChanged(nameof(NumList47));
            }
        }
        private ObservableCollection<DrawNumber> numList48 = new ObservableCollection<DrawNumber>();

        public ObservableCollection<DrawNumber> NumList48
        {
            get { return numList48; }
            set
            {
                numList48 = value;
                OnPropertyChanged(nameof(NumList48));
            }
        }

        #endregion
        private string patternsIcon;

        public string PatternsIcon
        {
            get { return patternsIcon; }
            set
            {
                patternsIcon = value;
                OnPropertyChanged(nameof(PatternsIcon));
            }
        }

        public static int TotalDraws { get; set; }
        public static int NumCount { get; set; }
        private static int TimerTickCounter { get; set; }
        public bool FirstTime { get; set; }

        public LotteryViewModel()
        {
            EnableButton = false;
            PatternButtonIsEnabled = false;
            IsBusy = true;

            PatternsIcon = @"Images\Spin Icon.png";
            ClosePopupBuble = "Hidden";
            DrawSequenceVisualPopupBuble = "Hidden";
            TopSimilaritiesPopupBuble = "Hidden";
            MinimizePopupBuble = "Hidden";
            ProgressBarVisibility = "Visible";

            WrongInputMessage = "Hidden";

            TopSimilaritiesOpen = new RelayCommand(TopSimilaritiesOpenHidden);
            TopSimilaritiesClose = new RelayCommand(TopSimilaritiesCloseHidden);

            NumberPatternsOpen = new RelayCommand(NumberPatternsOpenHidden);
            NumberPatternsClose = new RelayCommand(NumberPatternsCloseHidden);

            HoverOnTopSimilatities = new RelayCommand(MouseOver);
            HoverOfTopSimilatities = new RelayCommand(MouseLeave);

            HoverOnNumberPatterns = new RelayCommand(MouseOverNumberPatterns);
            HoverOfNumberPatterns = new RelayCommand(MouseLeaveNumberPatterns);

            HoverOnClose = new RelayCommand(MouseOverClose);
            HoverOfClose = new RelayCommand(MouseLeaveClose);

            HoverOnMinimize = new RelayCommand(MouseOverMinimize);
            HoverOfMinimize = new RelayCommand(MouseLeaveMinimize);

            NumberDownloader numberDownloader = new NumberDownloader();

            numberDownloader.CachConnectionFail += NumberDownloader_CachConnectionFail;

            SimilarityHolder.FirstLoop = true;

            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += progress_ProgressChanged;

            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromSeconds(1);
            Timer.Tick += Timer_Tick;

            WinResultList = new ObservableCollection<WinNumbersList>();


            FirstTime = true;
            SequenceVisualList = new ObservableCollection<DrawSequenceVisualList>();
            LoadData(progress);

            
            FindMatch = new RelayCommand(StartCalculations);
        }

        private void LoadData(IProgress<int> progressValue)
        {
            var task = LoadAllDataTasks(progressValue);

            Task.WhenAll(task);
        }

        private async Task LoadAllDataTasks(IProgress<int> progressValue)
        {
            NumberDownloader numberDownloader = new NumberDownloader();
            LottoTask = await numberDownloader.GetAllNumbersParalelAsync(progressValue);

            AllNumbersList = LottoTask;

            Patterns patterns = new Patterns();
            DrawList = await patterns.GeAllNumberPatternsListAsync(LottoTask);

            Patterns patterns1 = new Patterns(value => PatternsIcon = value, value => IsBusy = value, value => PatternButtonIsEnabled = value,
                value => PatternProgressVisibility = value, DrawList, x=> NumList1.Add(x),
                                                                      x=> NumList2.Add(x),
                                                                      x=> NumList3.Add(x),
                                                                      x=> NumList4.Add(x),
                                                                      x=> NumList5.Add(x),
                                                                      x=> NumList6.Add(x),
                                                                      x=> NumList7.Add(x),
                                                                      x=> NumList8.Add(x),
                                                                      x=> NumList9.Add(x),
                                                                      x=> NumList10.Add(x),
                                                                      x=> NumList11.Add(x),
                                                                      x=> NumList12.Add(x),
                                                                      x=> NumList13.Add(x),
                                                                      x=> NumList14.Add(x),
                                                                      x=> NumList15.Add(x),
                                                                      x=> NumList16.Add(x),
                                                                      x=> NumList17.Add(x),
                                                                      x=> NumList18.Add(x),
                                                                      x=> NumList19.Add(x),
                                                                      x=> NumList20.Add(x),
                                                                      x=> NumList21.Add(x),
                                                                      x=> NumList22.Add(x),
                                                                      x=> NumList23.Add(x),
                                                                      x=> NumList24.Add(x),
                                                                      x=> NumList25.Add(x),
                                                                      x=> NumList26.Add(x),
                                                                      x=> NumList27.Add(x),
                                                                      x=> NumList28.Add(x),
                                                                      x=> NumList29.Add(x),
                                                                      x=> NumList30.Add(x),
                                                                      x=> NumList31.Add(x),
                                                                      x=> NumList32.Add(x),
                                                                      x=> NumList33.Add(x),
                                                                      x=> NumList34.Add(x),
                                                                      x=> NumList35.Add(x),
                                                                      x=> NumList36.Add(x),
                                                                      x=> NumList37.Add(x),
                                                                      x=> NumList38.Add(x),
                                                                      x=> NumList39.Add(x),
                                                                      x=> NumList40.Add(x),
                                                                      x=> NumList41.Add(x),
                                                                      x=> NumList42.Add(x),
                                                                      x=> NumList43.Add(x),
                                                                      x=> NumList44.Add(x),
                                                                      x=> NumList45.Add(x),
                                                                      x=> NumList46.Add(x),
                                                                      x=> NumList47.Add(x),
                                                                      x => NumList48.Add(x)

                );
            Patterns.PopulatePatterns();
           
            NumberAndAverageTitle = new ObservableCollection<DrawNumberAndAverage>();
            NumberAndAverageHolder = new ObservableCollection<DrawNumberAndAverage>();
            NumberAndAverageHolder = await patterns.GetDrawNumbersAndAveragesAsync(LottoTask);

            TimerNumbersAndAverages = new DispatcherTimer(DispatcherPriority.SystemIdle);
            TimerNumbersAndAverages.Interval = TimeSpan.FromMilliseconds(1);
            TimerNumbersAndAverages.Tick += TimerNumbersAndAverages_Tick;
            TimerNumbersAndAverages.Start();

            AddLastWinNumbers(LottoTask, progressValue);

            List<Task<ObservableCollection<ColumnNumbersAndRepeats>>> numbersColumnsTask = new List<Task<ObservableCollection<ColumnNumbersAndRepeats>>>();

            int Counter = 1;

            while (Counter < 8)
            {
                ColumnNumberList specificNumberList = new ColumnNumberList();
                numbersColumnsTask.Add(specificNumberList.TopNumbersToColumns(LottoTask, Counter, progressValue));

                Counter++;
            }

            // progress 75

            WinNumbersListsHolder = await WinNumbersList.PopulateWinResultList(LottoTask, progressValue);

            Timer4 = new DispatcherTimer(DispatcherPriority.Background);
            Timer4.Tick += Timer4_Tick;
            Timer4.Interval = TimeSpan.FromMilliseconds(1);
            Timer4.Start();

            NumberColumnResults = await Task.WhenAll(numbersColumnsTask);

            Timer3 = new DispatcherTimer(DispatcherPriority.Background);
            Timer3.Tick += Timer3_Tick;
            Timer3.Interval = TimeSpan.FromMilliseconds(0.000001);
            Timer3.Start();

            SimilarityHolderViews = SimilarityHolder.FindBestNumbers(LottoTask, 2, 5);

            EnableButton = true;

        }

        private void TimerNumbersAndAverages_Tick(object sender, EventArgs e)
        {
            if (NumberAndAverageCounter < NumberAndAverageHolder.Count)
            {
                NumberAndAverageTitle.Add(NumberAndAverageHolder[NumberAndAverageCounter]);
                NumberAndAverageCounter++;
            }
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            if (WinResultListCounter<WinNumbersListsHolder.Count)
            {
                WinResultList.Add(WinNumbersListsHolder[WinResultListCounter]);
                WinResultListCounter++;
            }
            else
            {
                DispatcherTimer senderTimer = (DispatcherTimer)sender;
                senderTimer.Stop();
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {

            foreach (var item in NumberColumnResults)
            {
                switch (Timer3Count)
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
                        DispatcherTimer senderTimer = (DispatcherTimer)sender;
                        senderTimer.Stop();
                        break;
                }
                Timer3Count++;
            }
        }

        private void MouseLeaveNumberPatterns()
        {
            DrawSequenceVisualPopupBuble = "Hidden";
        }

        private void MouseOverNumberPatterns()
        {
            PopupBubleTopPlacement = "Right";
            PopupTopVisibility = "Visible";
            PopupBottomVisibility = "Hidden";
            PopupBubleText = "Number Patterns";
            DrawSequenceVisualPopupBuble = "Visible";
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

        private void progress_ProgressChanged(object sender, int e)
        {
            if (!NumberDownloaderProgressGetter.DownloadingIsDone)
                ProgressValue = e;
            else
                ProgressValue += e;

            if(ProgressValue == 100) Timer.Start();
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

        private void MouseLeaveClose()
        {
            ClosePopupBuble = "Hidden";
        }

        private void MouseOverClose()
        {
            PopupBubleTopPlacement = "Right";
            PopupTopVisibility = "Visible";
            PopupBottomVisibility = "Hidden";
            PopupBubleText = "Close";
            ClosePopupBuble = "Visible";
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
            TopSimilaritiesCloseVisibility = "Visible";
            NumberPatternsVisibility = "Hidden";
            NumberPatternsCloseVisibility = "Hidden";
        }
        private void TopSimilaritiesCloseHidden()
        {
            TopSimilaritiesCloseVisibility = "Hidden";
            TopSimilaritiesVisibility = "Visible";
            NumberPatternsVisibility = "Visible";
        }
        private void NumberPatternsOpenHidden()
        {
            NumberPatternsVisibility = "hidden";
            NumberPatternsCloseVisibility = "visible";
            TopSimilaritiesCloseVisibility = "Hidden";
            TopSimilaritiesVisibility = "Hidden";
        }
        private void NumberPatternsCloseHidden()
        {
            NumberPatternsCloseVisibility = "hidden";
            NumberPatternsVisibility = "visible";
            TopSimilaritiesVisibility = "Visible";
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

            progress.Report(4);
        }
       
       
       
    }
}
