using System;
using System.Collections.Generic;

namespace LetterCombinationPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Letter Combination Phone Number!");

            var res = LetterCombination("23");
            foreach (var str in res)
            {
                Console.WriteLine(str);
            }
        }

        // Using BFS for combinaiton

        public static List<string> LetterCombination(string digits)
        {
            List<string> res = new List<string>();

            if(digits == null || digits.Length == 0)
            {
                return res;
            }

            string[] mapping =
            {
                "0",
                "1",
                "abc",
                "def",
                "ghi",
                "jkl",
                "mno",
                "pqrs",
                "tuv",
                "wxyz"
            };

            LetterCombinationRecursive(res, digits, "", 0, mapping);


            return res;
        }


        public static void LetterCombinationRecursive(List<string> res, string digits, string current, int index, string[] mapping)
        {
            if(index == digits.Length)
            {
                res.Add(current);
                return;
            }

            string letters = mapping[digits[index] - '0'];

            for(int i=0; i < letters.Length; i++)
            {
                LetterCombinationRecursive(res, digits, current + letters[i], index + 1, mapping);
            }



        }


    }
}
