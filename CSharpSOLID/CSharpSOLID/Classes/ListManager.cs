﻿using System;
using System.Text;
using System.Collections.Generic;
namespace CSharpSOLID.Classes
{
    public class ListManager
    {
        public ListManager()
        {
        }

        /**
         * Couple of integer which the sum equals the value desired
         * param List of integers and the value wanted
         * return list of a couple of integers
         */
        public List<Tuple<int, int>> PairList(List<int> l, int value)
        {
            var result = new List<Tuple<int, int>>();
            if (l != null)
            {
                for (int i = 0; i < l.Count; i++)
                {
                    for (int j = i+1; j < l.Count; j++)
                    {
                        if (l[i] + l[j] == value)
                        {
                            if(!result.Contains(new Tuple<int, int>(l[i], l[j])) && !result.Contains(new Tuple<int, int>(l[j], l[i])))
                                result.Add(new Tuple<int, int>(l[i], l[j]));
                        }
                    }
                }
            }    
            return result;
        }

        /**
         * Couple of integer which the sum equals the value
         * param List of integers and the value wanted
         * return here a string with a couple of integers
         */
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

        /**
         * The first occurrence which the occurence is pair on the list
         * param List of integers
         * return int or null
         */
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
                    if (count % 2 == 0) return i;
                }
            }
            return null;
        }

        public void GreaterList(List<int> l)
        {
            if (l != null)
            {
                for (int i = 0; i < l.Count - 1; i++)
                {
                    if (l[i] > l[i + 1]) Console.WriteLine(l[i]);
                }
                Console.WriteLine(l[l.Count - 1]);
            }
        }
    }
}
