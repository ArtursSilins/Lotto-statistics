using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumCheck
{
    public static class SimilarityHolder
    {
        public static List<NumbersAndRepeats> NumberList { get; set; } = new List<NumbersAndRepeats>();
        public static List<NumbersAndRepeats> AlredyFoundNumberList { get; set; } 
        private static bool IsMatch { get; set; }

        /// <summary>
        /// If it's first time you don't need to compare numbers to AlreadyFoundNumbersList. 
        /// </summary>
        public static bool FirstLoop { get; set; }

        /// <summary>
        /// Add new numbers if this number combination does not exist, or increment repeats++ if numbers combination already is in NumberList. 
        /// </summary>
        /// <param name="numbers"></param>
        public static void AddNumbers(List<int> numbers)
        {
            // if no repeat in NumberList is found then in the last loop cicle number is added to NumberList 
            int notDuplicateCounter = 0;

            NumbersAndRepeats numbersAndRepeats = new NumbersAndRepeats();

            IsMatch = false;

            if (NumberList.Count == 0)
            {
                AddNewNum(numbers);    
            }
            else
            {

                foreach (var item in NumberList.ToList())
                {
                   
                    int similarNumCounter = 0;
                    notDuplicateCounter++;

                    var numbesExist = item.Numbers.All(numbers.Contains) && numbers.Count() == item.Numbers.Count(); 

                    if (numbesExist)
                    {

                        for (int num2 = 0; num2 < item.Numbers.Count; num2++)
                        {

                            if (numbers.Count() == item.Numbers.Count())
                            {
                                AddRepeatTimess(numbers, item, item.Numbers[num2], item.Numbers.Count, ref similarNumCounter);
                            }
                                                       
                        }

                    }
                    else if(notDuplicateCounter == NumberList.Count && IsMatch == false)
                    {
                        AddNewNum(numbers);
                    }
                   
                }
            }                        
            

        }
        /// <summary>
        /// Detect if numbers is in list, if is then incremet repeats++. 
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="numbersAndRepeats"></param>
        /// <param name="numFromList"></param>
        /// <param name="num2"></param>
        /// <param name="similarNumCounter"></param>
        /// <param name="notDuplicateCounter"></param>
        private static void AddRepeatTimess(List<int> numbers, NumbersAndRepeats numbersAndRepeats, int numFromList, int num2Count, ref int similarNumCounter)
        {
            foreach (var num in numbers)
            {
                if (num == numFromList)
                {
                    similarNumCounter++;
                }

                if (similarNumCounter == num2Count)
                {
                    IsMatch = true;
                    numbersAndRepeats.Repeat++;
                }

            }
        }
        /// <summary>
        /// Add new numbers to list and increment repeat count by 2.
        /// </summary>
        /// <param name="numbers"></param>
        private static void AddNewNum(List<int> numbers)
        {
            NumbersAndRepeats numbersAndRepeats = new NumbersAndRepeats();
            numbersAndRepeats.Numbers = new List<int>();  

            foreach (var item in numbers)
            {
                numbersAndRepeats.Numbers.Add(item);
            }
            numbersAndRepeats.Repeat = 2;

            NumberList.Add(numbersAndRepeats);
        }
        /// <summary>
        /// Check if numbers not already added to similar numbers list
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static bool CheckIfNumberExist(List<int> numbers)
        {
            bool exist = false;

            if (!FirstLoop)
            {
                if (AlredyFoundNumberList == null) return exist;

                foreach (var item in AlredyFoundNumberList)
                {
                    var a = item.Numbers.All(numbers.Contains);
                    if (a == true && item.Numbers.Count() == numbers.Count()) return exist = true;

                }

            }

            return exist;
        }
        /// <summary>
        /// Add to AlraedyFoundList to not add already found numbers
        /// </summary>
        /// <param name="NumberList"></param>
        public static void AddToAlreadyFoundList(List<NumbersAndRepeats> NumberList)
        {
            AlredyFoundNumberList = new List<NumbersAndRepeats>(NumberList);
        }
        /// <summary>
        /// Find similarities in two numbers
        /// </summary>
        /// <param name="lotteryTicketNumbers"></param>
        /// <param name="vikingLottoNumbers"></param>
        /// <param name="similarityCount"></param>
        private static void CheckSimilarities(VikingLottoNumbers lotteryTicketNumbers, VikingLottoNumbers vikingLottoNumbers, int similarityCount)
        {
            int counterForBool = 0;

            List<int> numbers = new List<int>();

            int endCounter = 0;
            int endCounter2 = 0;

            foreach (var ticketNum in lotteryTicketNumbers.NumCollection)
            {
                endCounter++;
                endCounter2 = 0;
                foreach (var lottoNum in vikingLottoNumbers.NumCollection)
                {
                    endCounter2++;              
                    if (ticketNum == lottoNum)
                    {
                        counterForBool++;

                        numbers.Add(ticketNum);
                    }
                  
                }

            }

            if (counterForBool > 1)
            {
                foreach (var item in GetAllCobinations(numbers))
                {
                    if (item.Count >= similarityCount)
                    {
                        if (!SimilarityHolder.CheckIfNumberExist(item))
                        {
                            SimilarityHolder.AddNumbers(item);
                        }
                    }
                }
            }
                     
        }

        private static List<List<int>> GetAllCobinations(List<int> numbers)
        {                     
            
            List<List<int>> combinationsList = new List<List<int>>();

            double count = Math.Pow(2, numbers.Count);

            for (int i = 1; i <= count - 1; i++)
            {
                List<int> combinations = new List<int>();

                string str = Convert.ToString(i, 2).PadLeft(numbers.Count, '0');
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        combinations.Add(numbers[j]);
                    }
                }

                if (combinations.Count > 1)
                    combinationsList.Add(combinations);
                else
                    combinations = null;
            }

            return combinationsList;
        }
        /// <summary>
        /// Compare each draw results to each draw results
        /// </summary>
        /// <param name="allNumbers"></param>
        /// <param name="similarityCount"></param>
        /// <param name="minRepeats"></param>
        /// <returns></returns>
        public static ObservableCollection<SimilarityHolderViewModel> FindBestNumbers(ObservableCollection<VikingLottoNumbers> allNumbers, int similarityCount, int minRepeats)
        {    
            
            Task<ObservableCollection<SimilarityHolderViewModel>> task = Task<ObservableCollection<SimilarityHolderViewModel>>.Factory.StartNew(() => {

                // detection to not compare the number to itself
                int RowCount1 = 0;
                int RowCount2 = 0;
                //

                foreach (var lotteryTicketNumbers in allNumbers)
                {
                    foreach (var vikingLottoNumbers in allNumbers)
                    {
                        if (RowCount1 != RowCount2)
                            CheckSimilarities(lotteryTicketNumbers, vikingLottoNumbers, similarityCount);

                        RowCount2++;
                        if (RowCount2 == allNumbers.Count)
                        {
                            RowCount2 = 0;
                        }
                    }

                    SimilarityHolder.FirstLoop = false;

                    SimilarityHolder.AddToAlreadyFoundList(SimilarityHolder.NumberList);

                    RowCount1++;

                }

               return AddToSimilarityHolderViews(minRepeats);
            });

            return task.Result;
        }

        private static ObservableCollection<SimilarityHolderViewModel> AddToSimilarityHolderViews(int minRepeats)
        {
            ObservableCollection<SimilarityHolderViewModel> SimilarityHolderViews = new ObservableCollection<SimilarityHolderViewModel>();

            foreach (var item in SimilarityHolder.NumberList)
            {

                if (minRepeats <= item.Repeat)
                {
                    SimilarityHolderViewModel similarityHolderViewModel = new SimilarityHolderViewModel();

                    similarityHolderViewModel.Repeats = item.Repeat;

                    for (int i = 0; i < item.Numbers.Count; i++)
                    {

                        switch (i)
                        {
                            case 0:
                                similarityHolderViewModel.Num1 = item.Numbers[i];
                                similarityHolderViewModel.VisibilityNum1 = "Visible";
                                break;
                            case 1:
                                similarityHolderViewModel.Num2 = item.Numbers[i];
                                similarityHolderViewModel.VisibilityNum2 = "Visible";
                                break;
                            case 2:
                                similarityHolderViewModel.Num3 = item.Numbers[i];
                                similarityHolderViewModel.VisibilityNum3 = "Visible";
                                break;
                            case 3:
                                similarityHolderViewModel.Num4 = item.Numbers[i];
                                similarityHolderViewModel.VisibilityNum4 = "Visible";
                                break;
                            case 4:
                                similarityHolderViewModel.Num5 = item.Numbers[i];
                                similarityHolderViewModel.VisibilityNum5 = "Visible";
                                break;
                            case 5:
                                similarityHolderViewModel.Num6 = item.Numbers[i];
                                similarityHolderViewModel.VisibilityNum6 = "Visible";
                                break;
                        }

                    }

                    SimilarityHolderViews.Add(similarityHolderViewModel);
                }

            }

            return new ObservableCollection<SimilarityHolderViewModel>(SimilarityHolderViews.OrderByDescending(x => x.Repeats));

        }

    }
}
