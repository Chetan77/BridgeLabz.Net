using System;

namespace DataStructure
{
    class ListTest
    {
        public void UnorderedListTest()
        {
            UnOrderedList<String> unOrderedList = new UnOrderedList<string>();
            Console.WriteLine("Enter the how meny words you want to add");
            int n = Utility.IntInput();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter" + i + 1 + "word");
                unOrderedList.AddData(Utility.StringInput());
            }
            /*unOrderedList.PopPos(3);
            unOrderedList.PrintList();
            unOrderedList.InsertPos("freeze", 3);
            unOrderedList.PrintList();
            */Console.WriteLine("enter the word you want to add or remove");
            string s = Utility.StringInput();

            AddOrRemoveFromUnordered(s, unOrderedList);
        }
        public string AddOrRemoveFromUnordered(string s, UnOrderedList<string> uList)
        {
            bool present = uList.Search(s);
            Console.WriteLine("presence"+present);
            if (present)
            {
                uList.Remove(s);
                Console.WriteLine("removed"+s);
            }
            else
            {
                uList.Append(s);
                Console.WriteLine("added" + s);
            }
            return s;
        }
        public void OrderedListTest()
        {
            OrderedList<int> orderedList = new OrderedList<int>();
            Console.WriteLine("enter how numbers you want to add");
            int n = Utility.IntInput();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the  number");
                orderedList.ListData(Utility.IntInput());
            }
            
            orderedList.PrintList();
            Console.WriteLine("enter the number to add or remove");
            int num = Utility.IntInput();
            AddOrRemoveFromOrdered(num, orderedList);
            orderedList.PrintList();

        }
        public int AddOrRemoveFromOrdered(int data, OrderedList<int> orderedList)
        {
            bool presence = orderedList.Search(data);
            Console.WriteLine(presence);
            if (presence)
            {
                orderedList.Remove(data);
                Console.WriteLine("removed");
                return data;
            }
            else
            {
                orderedList.ListData(data);
                Console.WriteLine("added");
            }
            return data;
        }
    }
}
