using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRectangularArray
{
    internal class Class4
    {
        static void Main (string[] args)
        {
            int[,] a = { { 1, 2 }, { 3, 4 } };
            int[,] b = { { 5, 6 }, { 7, 8 } };

            Console.WriteLine("================A  Matrix Elements===========");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
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


            int[,] c = new int[2, 2];
            // logic for multiplication
            for(int i=0;i<a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    for(int k =0;k<a.GetLength(0); k++)
                    {
                        c[i, j] = a[i, k] * b[k, j] + c[i, j];
                    }
                }
            }
            Console.WriteLine("================Mul of A and B  Matrix Elements===========");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"{c[i, j]}\t");
                }
                Console.WriteLine("\n");
            }









        }
    }
}
