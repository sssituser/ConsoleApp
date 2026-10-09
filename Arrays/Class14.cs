using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class14
    {
        static void Main (string[] args)
        {
            int[,] a = { { 12, 45, 76 }, { 56,88,66}, { 14,34,56} };

            Console.WriteLine(a[0,0]);
            Console.WriteLine(a[0,1]);
            Console.WriteLine(a[0,2]);
            Console.WriteLine(a[1,0]);
            Console.WriteLine(a[1,1]);
            Console.WriteLine(a[1,2]);
            Console.WriteLine(a[2,0]);
            Console.WriteLine(a[2,1]);
            Console.WriteLine(a[2,2]);

            int[,] array = { { 10, 30, 40 }, { 78, 56, 45 } };
            Console.WriteLine(array[0, 0]);
            Console.WriteLine(array[0, 1]);
            Console.WriteLine(array[0, 2]);
            Console.WriteLine(array[1, 0]);
            Console.WriteLine(array[1, 1]);
            Console.WriteLine(array[1, 2]);
        }
    }
}
