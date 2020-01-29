using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nfor vending machine enter 1 \nfor to find the day of the week enter 2" +
                "\nfor temperature conversion enter 3 \nfor to find monthly payments enter 4" +
                "\nfor square root enter 5 \nfor converting decimal to binary enter 6" +
                "\nfor swaping nibbles and finding the decimal enter 7 \nfor string permuatation enter 8" +
                "\nfor binary search enter 9 \nfor integer insertion sor enter 10" +
                "\nfor string insertion sor enter 11 \nfor integer bubble sort enter 12" +
                "\nfor binery search from file enter 13 \nfor mergeSort enter 14" +
                "\nfor anagram enetr 15 \nfor prime numbersv enter 16" +
                "\nfor to find prime palindrome enter 17 \nfor guess number enter 18" +
                "\nfor permuatations enter 19 \nfor regex string replace enter 20"); 
            int n = Utility.IntInput();
            switch (n){
                case 1:
                    VendingMachine.MoneyInptu();
                    break;
                case 2:
                    DayOfWeek.WeeekDay();
                    break;
                case 3:
                    TemperatureConversion.MethodType();
                    break;
                case 4:
                    MonthlyPayments.Payment();
                    break;
                case 5:
                    SqrtUsingNewtons.Sqrt();
                    break;
                case 6:
                    ToBinary.ConvertToBinary();
                    break;
                case 7:
                    DecimalToBinary.Binary();
                    break;
                case 8:
                    PermutationOfString.AllPermutation();
                    break;
                case 9:
                    BinarySearch.Binary();
                    break;
                case 10:
                    InsertionSortForIntegers.GetArray();
                    break;
                case 11:
                    InsertionSortForStringArray.SortStringArray();
                    break;
                case 12:
                    BubbleSortForIntegers.BubbleSort();
                    break;
                case 13:
                    BinarySearchFromFile.ReadWordsFromFile();
                    break;
                case 14:
                    MergeSort.ArrayElements();
                    break;
                case 15:
                    StringAnagram.CheckAnagram();
                    break;
                case 16:
                    PrimeNumbers.PrimeNums();
                    break;
                case 17:
                    PrimeNumbers.PrimePalimdrome();
                    break;
                case 18:
                    GuessNumber.GetGuessNumber();
                    break;
                case 19:
                    Permutations.CallerMethods();
                    break;
                case 20:
                    RegexReplace.UserInputs();
                    break;
                default:
                    Console.WriteLine("enter correct value");
                    break;
            }
        }

    }
}
