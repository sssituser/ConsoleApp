using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRectangularArray
{

    /*
     * Array of Arrays is called jagged Arrays
     * DataType[][] varname = new DataType[rows][];
     * In jagged rows are fixed , cols can vary
     */
    internal class Class5
    {
        static void Main (string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[3] {45,67,89};
            a[1] = new int[2] {56,78};
            a[2] = new int[4] {11,22,33,44};

            Console.WriteLine("Jagged Array elements");
            for (int i = 0; i < a.Length; i++)
            {
                for(int j=0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
