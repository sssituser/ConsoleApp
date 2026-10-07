using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class10
    {
        static void Main (string[] args)
        {
            int[] array = {6,89,3,4,5,6,78,5,23,45,3 };//6-2,89-1,3-2,4-1,5-2
            Console.WriteLine("========Array elements are=======");
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("========Array duplidate elements are=======");
            int[] dups = array
                  .GroupBy(x => x)
                  .Where(x => x.Count() == 2)
                  .Select(x => x.Key)
                  .OrderBy(x => x)
                  .ToArray();
            foreach(int i in dups)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("========Array Uniques elements are=======");
            int[] uarray = array
                           .GroupBy(x => x)
                           .Where(x => x.Count() == 1)
                           .Select(x => x.Key)
                           .OrderBy(x => x)
                           .ToArray();
            foreach(int i in uarray)
            {
                Console.WriteLine(i);
            }




        }

    }
}
