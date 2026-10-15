using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    /*
        Write a program to Sum of the digits of a given number /
        num = 123   Sum : 6
        num = 456   Sum : 15
        AM : public static
        RT : int
        Method : DigitSum
        PM : int

        Write a program to find the Max Digit of Given number .
        AM : public static
        Rt : int
        MN : GetMaxDigit
        PM : int

        AM : public static
        Rt : int
        MN : GetMinDigit
        PM : int
     */
    internal class Class4
    {

        public static int GetMaxDigit(int num)
        {
            int max = num % 10;
            while (num > 0)
            {
                int digit = num % 10;
                if (max < digit)
                {
                    max = digit;
                }
                num /= 10;
            }
            return max;
        }
        public static int GetMinDigit (int num)
        {
            int min = num % 10;
            while (num > 0)
            {
                int digit = num % 10;
                if (min > digit)
                {
                    min = digit;
                }
                num /= 10;
            }
            return min;
        }


        public static int DigitSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        static void Main (string[] args)
        {
            int num = 123;
            int res = DigitSum(num);
            Console.WriteLine($"{num} Digits Sum : {res}");
            num = 456;
            Console.WriteLine($"{num} Digits Sum : {DigitSum(num)}");
            Console.WriteLine($"{num} MiniDigit : {GetMinDigit(num)} and MaxDigit : {GetMaxDigit(num)}");
        }
    }
}
