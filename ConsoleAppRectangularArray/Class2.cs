using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRectangularArray
{
    internal class Class2
    {
        static void Main (string[] args)
        {
            int[,] a = { { 12, 34,78 }, { 56, 78,90 },{ 90,87,65} };
            Console.WriteLine("============A Matrix Elements=========");
            for(int row = 0; row < a.GetLength(0); row++)
            {
                for(int col=0; col < a.GetLength(1); col++)
                {
                    Console.Write($"{a[row,col]}\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("============A Matrix Transpose Elements=========");
            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    Console.Write($"{a[col, row]}\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
