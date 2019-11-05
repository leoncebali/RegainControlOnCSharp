using System;
using System.Text;
using System.Collections.Generic;
namespace CSharpSOLID.Classes
{
    public class ListManager
    {
        public ListManager()
        {
        }

        public List<Tuple<int, int>> PairList(List<int> l, int value)
        {
            var result = new List<Tuple<int, int>>();
            if (l!= null)
            {
                for (int i = 0; i < l.Count; i++)
                {
                    for (int j = i+1; j < l.Count; j++)
                    {
                        if (l[i] + l[j] == value)
                        {
                            result.Add(new Tuple<int, int>(l[i], l[j]));
                        }
                    }
                }
            }    
            return result;
        }

        public string PairListString(List<int> l, int value)
        {
            var result = new StringBuilder();
            if (l != null)
            {
                result.Append("{");
                for (int i = 0; i < l.Count; i++)
                {
                    for (int j = i + 1; j < l.Count; j++)
                    {
                        if (l[i] + l[j] == value)
                        {
                            if (!result.ToString().Contains("" + l[i]))
                            {
                                result.Append(new Tuple<int, int>(l[i], l[j]));
                                if(j < l.Count - 1) result.Append(",");
                            }
                        }
                    }
                }
                result.Append("}");
            }
            return result.ToString();
        }

        public int? FirstOccurrence(List<int> l)
        {
            if (l != null)
            {
                foreach (var i in l)
                {
                    int count = 0;
                    for (int j = 0; j < l.Count; j++)
                    {
                        if (i == l[j]) count++;
                    }
                    if (count == 2) return i;
                }
            }
            return null;
        }
    }
}
