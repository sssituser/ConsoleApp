using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class11
    {
        static void Main (string[] args)
        {
            int[] array = { 6, 89, 3, 4, 5, 6, 78, 5, 23, 45, 3 };

            var e1 = array.Distinct().OrderBy(x => x).Skip(2).First();
            Console.WriteLine($"Minimum :{e1}");
            var e2 = array.Distinct().OrderByDescending(x=>x).Skip(0).First();
            Console.WriteLine(e2);
                        
        }
    }
}
