using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class6
    {
        static void Main (string[] args)
        {
            double[] f = { 6.7,8.9,4.5,9.8,9.6};
            Console.WriteLine("Dispalying the elemetns using index ");
            Console.WriteLine(f[0]);
            Console.WriteLine(f[1]);
            Console.WriteLine(f[2]);
            Console.WriteLine(f[3]);
            Console.WriteLine(f[4]);
            Console.WriteLine("Array elements using for loop");
            for (int i = 0; i < f.Length; i++)
            {
                Console.WriteLine(f[i]);
            }
            Console.WriteLine("Array elements using foreach looop");
            foreach(double d in f)
            {
                Console.WriteLine(d);
            }

         }
    }
}
