using System;
using System.Collections.Generic;
using System.Text;
using CSharpSOLID.Classes;

namespace CSharpSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            Console.WriteLine(p.isPalindrome2("MakoXokam"));

            InverseSentence ist = new InverseSentence();
            Console.WriteLine(ist.InverseMe("la vie est belle"));

            ListManager lm = new ListManager();
            Console.WriteLine(lm.PairListString(new List<int> { 2, 5, 3, 7, 8, 9, 7, 6, 5, 3, 4, 5, 10, 15, 65, 8, 76, 32, 12, 6, 7, 8, 1 }, 16));

            Verlan v = new Verlan();
            Console.WriteLine(v.ReverseMe("yes"));

            Console.WriteLine(lm.FirstOccurrence(new List<int> {2,5,4,4,3,2,5,2 }));
            Console.WriteLine(lm.FirstOccurrence(new List<int> { 2, 5, 3, 2, 5, 2, 5 }));
            List<int[,]> list = PairList(new List<int> { 2,5,3,7,8,9,7,6,5,3,5,10,15,65,8,76,32,12,6,7,8,1}, 16);
            //foreach(int[,] ml in list)
              //  foreach(int t in ml)
                //    Console.WriteLine(t);

            //try
            //{
            //    string s = null;
            //    for(int i =0; i<s.Length; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("try"+s);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error {0}", ex.Message);
            //    //throw ex;
            //}
            //finally
            //{
            //    Console.WriteLine("finally");
            //}
            //Console.WriteLine("End");
        }

        private static List<int[,]> PairList (List<int> l, int val)
        {
            var result = new List<int[,]>();
            if(l != null){
                for(int i =0; i<l.Count; i++)
                {
                    for(int j = i+1; j<l.Count; j++)
                    {
                        if(l[i]+l[j] == val)
                        {
                            var tab = new int[,] { { l[i], l[j] } };
                            result.Add(tab);
                            //l.Remove(l[j]);
                            l.Remove(l[i]);
                        }
                    }
                }
            }
            return result;
        }

        private bool Palindrome(string s)
        {
            int t = s.Length/2;
            bool result = false;
            StringBuilder ss = new StringBuilder();

            for(int i =0; i<= s.Length-1; i++)
            {
                if (s[i] == s[t - i])
                {
                    result = true;
                }
            }
            foreach(char c in s)
            {

            }
            return result;
        }
    }
}
