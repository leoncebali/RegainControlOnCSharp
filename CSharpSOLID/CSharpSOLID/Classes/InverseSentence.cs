using System;
using System.Text;
namespace CSharpSOLID.Classes
{
    public class InverseSentence
    {
        public InverseSentence()
        {
        }

        public string InverseMe(string s)
        {
            StringBuilder result = new StringBuilder();
            if (!string.IsNullOrEmpty(s))
            {
                string[] word = s.Split(" ");
                for (int i = word.Length - 1; i >=0; i--)
                {
                    result.Append(word[i]);
                    if (i > 0) result.Append(" ");
                }
            }
            return result.ToString();
        }
    }
}
