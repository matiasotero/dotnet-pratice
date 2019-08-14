using System;
using System.Collections.Generic;
using System.Linq;
using testing_dotnet.Models;

namespace testing_dotnet
{
    class Program
    {
        static List<int> listInt = new List<int>() { 1, 2, 4, 4, 5, 7, 3, 3, 2, 9, 8, 12, 4, 1, 3, 6 };
        static void Main(string[] args)
        {
            // // Exercise 1 (Filter distinct values from an array)
            // Exercise_1 exercise1 = new Exercise_1(listInt);
            // exercise1.PrintList(listInt);
            // Console.WriteLine("Inicial list:");
            // exercise1.PrintList(listInt);

            // Console.WriteLine("Filtered list:");
            // exercise1.PrintList(exercise1.FilterList());

            // Console.WriteLine("Filtered list (yield statement):");
            // foreach(int item in exercise1.FilterListWithYield())
            // {
            //     Console.WriteLine(item);
            // }

            // // Exercise 2 (Mario Bros Ladder)
            // Console.WriteLine("Exercise 2");
            // Exercise_2 exercise2 = new Exercise_2(10);
            // foreach(string item in exercise2.BuildLadderMarioBros())
            // {
            //     Console.WriteLine(item);
            // }           

            // Exercise 3 (Palindrome)
            Exercise_3 exercise3 = new Exercise_3();
            string result = exercise3.IfPalindrome("may a mooddy baby doom a yam") ? "Es palíndromo" : "No es palíndromo";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
