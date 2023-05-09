using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(String word)
        {
            char[] wordReverse = word.ToCharArray();
            Array.Reverse(wordReverse);
            string newWord = new string(wordReverse);
            return word.Equals(newWord);
        }
    }
}
