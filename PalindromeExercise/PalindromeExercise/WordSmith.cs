using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            char[] array = word.ToCharArray();
            Array.Reverse(array);
            string palindrome = new string(array);

            if (word == palindrome)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
