using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRectangularArray
{
    internal class Class3
    {
        static void Main (string[] args)
        {
            int[,] a = { {10,20 },{ 30, 40 } };
            int[,] b = { {1,2 },{ 3, 4 } };

            Console.WriteLine("================A  Matrix Elements===========");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"{a[i,j]}\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("================B  Matrix Elements===========");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"{b[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("================Sum of A and B  Matrices Elements===========");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j] + b[i,j]}\t");
                }
                Console.WriteLine("\n");
            }


        }
    }
}
