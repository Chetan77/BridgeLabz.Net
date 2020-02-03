using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            /*UnOrderedList<String> li = new UnOrderedList<String>();
            li.AddData("bhar");
            li.AddData("chetan");
            li.AddData("kishya");
            li.AddData("sada");
            li.AddData("sunya");
            li.Append("sada");
            li.InsertPos("bharat", 1);
            li.AddData("choudhari");
            //li.Pop();
            Object dta=li.PopPos(3);
            Console.WriteLine("removed(pop pos) ele is "+dta);
            li.Remove("sada");
            bool b = li.Search("choudhari");
            if (b)
            {
                Console.WriteLine("element is present "+b);
            }
            else
            {
                Console.WriteLine("element is not present "+b);
            }
            bool isEmpty = li.IsEmpty();
            if (isEmpty)
            {
                Console.WriteLine("list is not empty "+isEmpty);
            }
            int s = li.Size();
            Console.WriteLine("size of a list is " + s);
            int n=li.Index("chetan");
            Console.WriteLine("index is " + n);*/

            /*OrderedList<int> ol = new OrderedList<int>();
            ol.ListData(15);
            ol.ListData(13);
            ol.ListData(10);
            ol.ListData(17);
            int size = ol.Size();
            Console.WriteLine(size);*/
            ListTest listTest = new ListTest();
            Console.WriteLine("enter 1 for unordered list \nent 2 for ordered list" +
                "enter 3 for stack \nenter 4 for queue \nenter 5 for palindrome" +
                "\nenter 6 for hashing \nenter 7 for prime numbers " +
                "\nenter 8 for prime anagram \nenter 9 for prime number using stack" +
                "\nenetr 10 for prime anagram using queue \nenter 11 for calender" +
                "\nenter 12" +
                " for binary tree");
            int a = Utility.IntInput();
            switch (a)
            {
                case 1:
                    listTest.UnorderedListTest();
                    break;
                case 2:
                    listTest.OrderedListTest();
                    break;
                case 3:
                    SimpleBalancedParanthesis.BalancedParanthesis();
                    break;
                case 4:
                    BankCashCounter.BankCashCounterImpl();
                    break;
                case 5:
                    PalindromeUsingDequeue.Palindrome();
                    break;
                case 6:
                    hashingFunctionToSearch.Test();
                    break;
                case 7:
                    PrimeNumber.Prime();
                    break;
                case 8:
                    PrimeAnagrams.PrimeAnagram();
                    break;
                case 9:
                    PrimeAnagramsInRreverseOrder.PrimeAnagramsStack();
                    break;
                case 10:
                    PrimeAnagramsUsingQueue.PrintPrimeInQueue();
                    break;
                case 11:
                    Calender.CalenderPrint();
                    break;
                case 12:
                    BinarySearchTree<int>.BinaryTree();
                    break;
                default:
                    Console.WriteLine("enter correct value");
                    break;
            }
        }
    }
}
