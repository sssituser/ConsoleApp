using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class13
    {
        static void Main (string[] args)
        {
            int[] array = { 56, 8, 90, 90, 91, 34, 23, 67, 88, 45, 90, 97, 8, 7, };

            Console.WriteLine("Array elements are");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            int[] res1 = array.Distinct().OrderBy(x => x).ToArray();

            Console.WriteLine("After removing duplicates");
            foreach (int i in res1)
            {
                Console.WriteLine(i);
            }

            int fh = array.Distinct().OrderByDescending(x => x).First();
            Console.WriteLine($"Max :{fh}");

            int sh = array.Distinct().OrderByDescending(x => x).Skip(1).First();
            Console.WriteLine($"Second Hightest :{sh}");

            int th = array.Distinct().OrderByDescending(x => x).Skip(2).First();
            Console.WriteLine($"Third Hightest  :{th}");

            int fl = array.Distinct().OrderBy(x => x).First();
            Console.WriteLine($"First Lowest    : {fl}");

            int sl = array.Distinct().OrderBy(x => x).Skip(1).First();
            Console.WriteLine($"Second Lowest   : {sl}");

            int tl = array.Distinct().OrderBy(x => x).Skip(2).First();
            Console.WriteLine($"Third Lowest    : {tl}");

        }
    }
}
