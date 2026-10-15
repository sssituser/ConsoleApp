using System;


namespace ConsoleAppMethods
{
    internal class Class1
    {
        public static int Average(int num1,int num2,int num3)
        {
            return (num1 + num2+num3)/3;
        }
        static void Main (string[] args)
        {
            int res1 = Average(1, 2, 3);

            Console.WriteLine($"Average is : {res1}");
            Console.WriteLine($"Average is : {Average(4,5,6)}");
        }
    }
}
