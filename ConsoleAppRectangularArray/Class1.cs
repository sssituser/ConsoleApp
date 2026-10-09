using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRectangularArray
{
    internal class Class1
    {
        static void Main (string[] args)
        {
            int[,] a = { { 34, 56,54 }, { 67, 89,66 }, { 76, 98,44 } };

            Console.WriteLine("Array elements in rows and cols");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{a[i, j]}\t");

                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Diagonal Elements of the Array");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   if(i==j || i+j == 2)
                    {
                        Console.Write($"{a[i, j]}\t");
                    }
                    else
                    {
                        Console.Write($"\t");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Diagonal Elements of the Array");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j || i + j == 2)
                    {
                         Console.Write($"\t");
                    }
                    else
                    {
                        Console.Write($"{a[i, j]}\t");
                       
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
