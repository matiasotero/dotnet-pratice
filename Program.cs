using System;
using System.Collections.Generic;
using System.Linq;

namespace testing_dotnet
{
    class Program
    {
        static List<int> listInt = new List<int>() { 1, 2, 4, 4, 5, 7, 3, 3, 2, 9, 8, 12, 4, 1, 3, 6 };
        static void Main(string[] args)
        {
            // Exercise 1
            // Excerise_1.PrintList(listInt);
            // Console.WriteLine("Inicial list:");
            // Excerise_1.PrintList(listInt);

            // Console.WriteLine("Filtered list:");
            // Excerise_1.PrintList(Excerise_1.FilterList(listInt));

            // Console.WriteLine("Filtered list (yield statement):");
            // Excerise_1.PrintList(Excerise_1.FilterListWithYield(listInt).ToList());

            // Exercise 2
            Console.WriteLine("Exercise 2");
            Exercise_2 exercise2 = new Exercise_2(10);
            foreach(string item in exercise2.BuildLadderMarioBros())
            {
                Console.WriteLine(item);
            }           

            Console.ReadLine();
        }
    }
}
