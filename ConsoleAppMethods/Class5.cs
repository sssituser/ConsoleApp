using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    /*
        AM : public static
        RT : int
        MN : Reverse
        PM : int
     */
    internal class Class5
    {

        public static bool IsPalindrome(int num)
        {
            int copy = num;
            int rev = 0;
            while (copy > 0)
            {
                rev = rev * 10 + copy % 10;
                copy /= 10;
            }
            return num == rev;
        }
        public static int Reverse(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }
        static void Main (string[] args)
        {
            int num = 123;
            Console.WriteLine($"{num} Reverse is : {Reverse(num)}");
            Console.WriteLine($"{num} is Palindrome : {IsPalindrome(num)}");
            num = 121;
            Console.WriteLine($"{num} is Palindrome : {IsPalindrome(num)}");

        }
    }
}
