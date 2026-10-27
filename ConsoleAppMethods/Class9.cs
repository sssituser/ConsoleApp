using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    internal class Class9
    {

        public static int DigitCount(int num) 
        {
            int count = 0;
            while (num > 0) 
            {
                int digit = num % 10;
                count++; // 
                num = num / 10;
            }
            return count;
        }
        public static int Power(int  num,int pow) // 
        {
            int res = 1;
            for(int i = 1; i <= pow; i++)// 
            {
                res = res * num;// res = 9
            }
            return res;

        }
        public static bool IsArmstrong(int num) 
        {
            int count = DigitCount(num); 
            int copy = num;
            int sum = 0;
            while (copy > 0)
            {
                int digit = copy % 10; 
                sum = sum + Power(digit, count);
                copy = copy / 10;


            }
            return num == sum;
        }
        static void Main (string[] args)
        {

            Console.WriteLine(IsArmstrong(153));
            Console.WriteLine(IsArmstrong(123));
        }
    }
}
