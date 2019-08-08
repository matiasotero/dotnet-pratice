using System;
using System.Collections.Generic;
using System.Linq;

namespace testing_dotnet
{
    class Program
    {
        string test = "";
        static List<int> listInt = new List<int>() { 1, 2, 4, 4, 5, 7, 3, 3, 2, 9, 8, 12 };

        private static List<int> FilterList(List<int> list)
        {
            return list.Distinct().ToList();
        }

        public static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Inicial list:");
            PrintList(listInt);
            List<int> outputList = FilterList(listInt);
            Console.WriteLine("Filtered list:");
            PrintList(outputList);
            Console.ReadLine();
        }
    }
}
