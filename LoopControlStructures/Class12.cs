using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class12
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                Console.WriteLine(digit);
                sum = sum + digit;
                count++;
                num = num / 10;
            }
            Console.WriteLine($"Sum is ; {sum}");
            Console.WriteLine($"Count is : {count}");
            int avg = sum / count;
            Console.WriteLine($"Average is  : {avg}");
        }
    }
}
