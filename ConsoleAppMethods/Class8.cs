using System;


namespace ConsoleAppMethods
{

    /*
     * num = 6    factors = 1,2,3  sum = 6
     * MN : IsPerfect
     * RT : bool
     * PM : int
     * AM : public static
     * 
     * 
     */
    internal class Class8
    {
        public static bool IsPerfect(int num)
        {
            int sum = 0;
            for(int i = 1; i < num; i++) 
            {
                if (num % i == 0)
                {
                    sum = sum + i; 
                }
            }
            return sum == num;
        }
        public static bool IsPrime (int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            return count == 2;
        }
        static void Main (string[] args)
        {
            int num = 6;
            Console.WriteLine($"{num} is a Perfect Number : {IsPerfect(num)}");
            num = 7;
            Console.WriteLine($"{num} is a Perfect Number : {IsPerfect(num)}");
            num = 8;
            Console.WriteLine($"{num} is a Perfect Number : {IsPerfect(num)}");
            num = 24;
            Console.WriteLine($"{num} is a Perfect Number : {IsPerfect(num)}");
            num = 28;
            Console.WriteLine($"{num} is a Perfect Number : {IsPerfect(num)}");

            Console.WriteLine(IsPrime(2));
            Console.WriteLine(IsPrime(4));
        }
    }
}

// 8   1,2,4 => 7  24  1,2,3,4,6,8,12 => 36

// 6   1,2,3 => 6