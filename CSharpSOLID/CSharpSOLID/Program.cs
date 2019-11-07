using System;
using System.Collections.Generic;
using CSharpSOLID.Classes;

namespace CSharpSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            ListManager lm = new ListManager();
            StringManager sm = new StringManager();

            Console.WriteLine(sm.isPalindrome2("Merdrem"));

            Console.WriteLine(sm.InverseSentence("Why so serious when life is so beautiful"));

            Console.WriteLine(sm.Verlan("esrever"));

            Console.WriteLine(lm.FirstOccurrence(new List<int> {2,5,4,4,3,2,5,2 }));
            Console.WriteLine(lm.FirstOccurrence(new List<int> { 2, 5, 3, 2, 5, 2, 5 }));

            Console.WriteLine(lm.PairListString(new List<int> {2, 5, 3, 7, 8, 9, 7, 6, 5, 3, 5, 10, 15, 65, 8, 76, 32, 12, 6, 7, 8, 1}, 16));
            List<Tuple<int, int>> list = lm.PairList(new List<int> { 2, 5, 3, 7, 8, 9, 7, 6, 5, 3, 5, 10, 15, 65, 8, 76, 32, 12, 6, 7, 8, 1 }, 16);
            foreach (var ml in list)
                Console.WriteLine(ml);

            LetterStruct ls = sm.LetterCounter("la terre est ronde");
            Console.WriteLine("Consonant number is: {0}",ls.Consonant);
            Console.WriteLine("Vowel number is: {0}", ls.Vowel);

            Console.WriteLine(sm.FirstCharacter("aabcddfgh"));

            lm.GreaterList(new List<int> { 4, 6, 5, 2, 3 });

        }
    }
}
