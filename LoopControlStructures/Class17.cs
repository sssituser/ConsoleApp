using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class17
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); 
            int copy = num;
            int rev = 0;
            
            while (num > 0) 
            {
                int digit = num % 10; 
                rev = rev * 10 + digit; 
                num = num / 10; 
            }
            if (num == rev)
            {
                Console.WriteLine($"{copy} is a Palindrome number");
            }
            else
            {
                Console.WriteLine($"{copy} is not Palindrome number");
            }
        }
    }
}
