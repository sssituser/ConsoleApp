using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    /*
     * Write a program to check given number is Armstrong or not
     * num = 153   1cube+5cube+3cube => 153
     * num = 1634  1pow4+6pow4+3pow4+4pow4
     * 
     * 1.number of digits equals to power:count the digits
     * 2.Separate the digit and find the powervalue.
     * 3.Sum of the power values
     * 4. and compare sum and original number if the they are equal,
     * AM: public static
     * RT: bool
     * MN: IsArmstrong
     * PM: integer
     * 
     * Example :  power : 5 power 2 => 5*5      3 power 4 => 3*3*3*3
     * AM : public static
     * RT : int
     * MN : power
     * PM : 2-ints
     * 
     * 
     * AM : public static
     * RT : int
     * MN : DigitCount
     * PM : int
     */
    internal class Class6
    {
        public static int DigitCount (int num)
        {
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                count++;
                num /= 10;
            }
            return count;
        }
        public static int PowerValue (int basee, int power)// 2 to power 3
        {
            int res = 1;
            for (int i = 1; i <= power; i++) //3<=3
            {
                res =res* basee;//res = 8
            }
            return res;
        }
        public static bool IsArmstrong(int num) 
        {
            int copy = num;
            int power = DigitCount(copy); 
            int sum = 0;
            while (copy > 0) 
            {
                int digit = copy % 10; 
                sum = sum + PowerValue(digit, power);
                copy = copy / 10; 
            }
            return num == sum;
        }
        static void Main (string[] args)
        {
            int num = 153;
            bool res = IsArmstrong(num);
            Console.WriteLine($"{num} Is an Armstrong number : {res}");
            num = 1634;
            Console.WriteLine($"{num} Is an Armstrong number : {IsArmstrong(num)}");
            num = 123;
            Console.WriteLine($"{num} Is an Armstrong number : {IsArmstrong(num)}");


        }
    }
}
