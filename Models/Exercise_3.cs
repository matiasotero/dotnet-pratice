using System;
using System.Collections.Generic;
using testing_dotnet.Interfaces;

namespace testing_dotnet.Models
{
    public class Exercise_3 : IExercise_3
    {
        public bool IfPalindrome(string word)
        {
            char[] reverseArray = word.Trim().ToCharArray();
            Array.Reverse(reverseArray);
            return new string(reverseArray) == word.Trim();
        }
    }
}