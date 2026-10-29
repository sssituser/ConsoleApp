using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    //Write a program to generate list of Palindrome numbers for the given range.
    // start = 10  end = 1000
    // Palindromes : 11,22,33,44,...99,.......101,111,121,131.....999.
    // AM : public static
    // MN : GetPalindromes
    // RT : string
    // PM : two ints  start and end
    internal class Class10
    {
        public static string GetPalindromes(int start,int end)
        {
            string res = string.Empty;
            for(int i = start; i <= end; i++)
            {
                if (Class5.IsPalindrome(i))
                {
                    res += i+",";
                }
            }
            return $"Palindromes : {res.Substring(0,res.Length-1)+"."}";
        }
        static void Main (string[] args)
        {
            Console.WriteLine(GetPalindromes(10,1000));
        }
    }
}
