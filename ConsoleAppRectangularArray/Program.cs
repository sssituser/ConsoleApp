using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRectangularArray
{
    internal class Program
    {
        static void Main (string[] args)
        {
            //int[,] a = new int[2, 2]; //Declare

            // int[,] a = new int[2, 2] { {34,56 },{ 67,89} };  Initilaization
            // int[,] a =  { {34,56 },{ 67,89} };  Initilaization

            int[,] a = { { 34, 56 }, { 67, 89 } };
            Console.WriteLine(a[0,0]);
            Console.WriteLine(a[0,1]);
            Console.WriteLine(a[1,0]);
            Console.WriteLine(a[1,1]);
            Console.WriteLine("Displaying the elements by using foreach");
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Displaying the elemlent using for loop");
            for(int i = 0; i < 2; i++) // i = 0 0<2-T i = 1 1<2 i = 2 2<2 // rows
            {
                for(int j = 0; j < 2; j++)// j=0 j<2-T j=1 1<2-T j=2 2<2-F // cols
                {
                    Console.WriteLine(a[i,j]);
                }
            }

            Console.WriteLine("Displaying the array element using for loop in rows, cols");
            for(int i = 0;i < 2; i++) // i = 0 0<2-T i = 1 1<2 i=2 2<2
            {
                for(int j = 0;j < 2; j++) // j = 0 0<2-T j = 1 1<2 j=2 2<2
                {
                    Console.Write($"{a[i, j]}\t"); // 36   56 nextline 67   89 nextline
                }
                Console.WriteLine("\n");
            }
        }
    }
}
