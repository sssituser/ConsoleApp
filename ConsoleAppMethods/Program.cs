using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    /*Method must follow Pascal Case Naming 
     * Create a method which can perform sum of two numbers.
     * Method       : Sum  or Add
     * Parameters   : Two Integers
     * Retrun Type  : Integer
     * AccessModifer: pulic static
     * 
     * Create a method which can perform sub of two numbers
     * Method : Sub
     * Paramte: Two Integer
     * Return : Int
     * Access : public static
     */
    internal class Program
    {
        public static int Sum(int num1,int num2)
        {
            return num1 + num2;
        }
        public static int Sub (int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Mul (int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Div (int num1, int num2)
        {
            return num1 / num2;
        }
        static void Main (string[] args)
        {
            // Recomanded way to call

            int res1 = Sum(2, 3);
            int res2 = Sub(2, 3);
            int res3 = Mul(2, 3);
            int res4 = Div(2, 3);

            Console.WriteLine($"{res1}  {res2}   {res3}    {res4}");




        }
    }
}
