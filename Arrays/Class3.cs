using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class3
    {
        static void Main (string[] args)
        {
            string[] array1 = {"abc","def","xyz","pqr","lmn" };
            Console.WriteLine($"Total elements in the array : {array1.Length}");
            for(int i=0; i<array1.Length; i++)
            {
                Console.WriteLine($"{i} : {array1[i]}");
            }
        }
    }
}
