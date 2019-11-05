using System.Text;
namespace CSharpSOLID.Classes
{
    public class Verlan
    {
        public Verlan()
        {
        }

        public string ReverseMe(string s)
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
    }
}
