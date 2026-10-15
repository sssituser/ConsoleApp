using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppRectangularArray
{
    internal class Class6
    {
        static void Main (string[] args)
        {
            int[] array = { 56, 8, 90, 90, 91, 34, 23, 67, 88, 45, 45, 23, 90, 97, 8, 7, };

            int[] dups = array.GroupBy(x=>x).Where(x=>x.Count()>=2).Select(g=>g.Key).OrderBy(x=>x).ToArray();
            foreach (var item in dups)
            {
                Console.WriteLine(item);
            }
            int[] uniques = array.GroupBy(x => x).Where(x => x.Count() == 1).Select(g => g.Key).OrderBy(x => x).ToArray();
            Console.WriteLine("Unique element");
            
            foreach (var item in uniques)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Second highest");
            int sh = array.Distinct().OrderByDescending(x => x).Skip(1).FirstOrDefault();

            Console.WriteLine($"Second Hightest elemng : {sh}");
            Console.WriteLine("Second lowest");
            int lh = array.Distinct().OrderBy(x => x).Skip(1).FirstOrDefault();

            Console.WriteLine($"Second lowest elemng : {lh}");

          
                  

           

         

        }
    }
}
