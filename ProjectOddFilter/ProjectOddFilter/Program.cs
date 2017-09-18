using System;
using System.Collections.Generic;

namespace ProjectOddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an OddFilter function that takes a list as a parameter,
            // and returns a new list with every odd element from the orignal list
            List<int> originalList = new List<int> { 1, 2, 3, 4, 5 };
            List<int> oddElements = new List<int> {};

            // In case of the example input above, the given PrintList function should print 1 3 5 

            OddFilter(originalList, oddElements);
            PrintList(oddElements);
            Console.ReadLine();
        }

        private static void PrintList(List<int> newList)
        {
            foreach (int element in newList)
            {
                Console.Write("{0} ", element);
            }
        }
        public static void OddFilter (List<int> oldList, List<int> newList)
        {
            for (int i = 0; i < oldList.Count; i++)
            {
                if (oldList[i]%2 == 1)
                {
                    newList.Add(oldList[i]);
                }
            }
        }
    }
}
