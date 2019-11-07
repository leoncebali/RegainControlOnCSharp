using System;
using System.Text;
namespace CSharpSOLID.Classes
{
    public class StringManager
    {
        public StringManager()
        {
        }

        /**
         * Reverse the whole sentence
         * param string s the sentence to test
         * return string the sentence reversed
         */
        public string InverseSentence(string s)
        {
            StringBuilder result = new StringBuilder();
            if (!string.IsNullOrEmpty(s))
            {
                string[] word = s.Split(" ");
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result.Append(word[i]);
                    if (i > 0) result.Append(" ");
                }
            }
            return result.ToString();
        }

        /**
         * Reverse the word
         * param string s the word to test
         * return string
         */
        public string Verlan(string s)
        {
            StringBuilder result = new StringBuilder();
            if (!string.IsNullOrEmpty(s))
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    result.Append(s[i]);
                }
            }
            return result.ToString();
        }


        /**
         * Check if the word is a palindrome
         * param string s the word to test
         * return Boolean 
         */
        public Boolean isPalindrome(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                int size = s.Length / 2;
                int count = 0;
                for (int i = 0; i < size; i++)
                {
                    if (s[i] == s[s.Length - 1 - i])
                    {
                        count++;
                    }
                }
                if (count == size)
                {
                    return true;
                }
            }
            return false;
        }

        /**
         * Second method
         * Check if the word is a palindrome
         * param string s the word to test
         * return Boolean 
         */
        public Boolean isPalindrome2(string s)
        {
            StringBuilder _inverse = new StringBuilder();
            if (!string.IsNullOrEmpty(s))
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    _inverse.Append(s[i]);
                }
            }
            return s.ToLower().Equals(_inverse.ToString().ToLower()) ? true : false;
        }

        /**
         * Count the numbers of vowel and consonant
         * param string
         * return struct type
         */
        public LetterStruct LetterCounter(string s)
        {
            LetterStruct ls = new LetterStruct();
            if (!string.IsNullOrEmpty(s))
            {
                foreach(char c in s)
                {
                    if (char.IsLetter(c))
                    {
                        if ("aeiouy".Contains("" + c))
                        {
                            ls.Vowel++;
                        }
                        else
                        {
                            ls.Consonant++;
                        }
                    }
                }
            }
            return ls;
        }
    }
}
