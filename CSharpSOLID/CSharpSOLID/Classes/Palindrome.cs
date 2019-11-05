using System;
using System.Text;
namespace CSharpSOLID.Classes
{
    public class Palindrome
    {
        public Palindrome()
        {

        }

        public Boolean isPalindrome(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                int size = s.Length / 2;
                int count = 0;
                for(int i=0; i<size; i++)
                {
                    if(s[i] == s[s.Length - 1 - i])
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

        public Boolean isPalindrome2(string s)
        {
            StringBuilder _inverse = new StringBuilder();
            if (!string.IsNullOrEmpty(s))
            {
                for(int i = s.Length-1; i>=0 ; i--)
                {
                    _inverse.Append(s[i]);
                }
            }
            return s.ToLower().Equals(_inverse.ToString().ToLower()) ? true : false;
        }
    }
}
