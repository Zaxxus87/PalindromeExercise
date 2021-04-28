using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public static bool IsAPalindrome(string s)
        {
            char[] c = s.ToCharArray();
            Array.Reverse(c);
            string revS = new String(c);
            return s == revS;
        }
    }
}
