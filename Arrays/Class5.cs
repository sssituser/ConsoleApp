using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class5
    {
        static void Main (string[] args)
        {
            string[] array = {"abc","def","pqr","lmn" };
            Console.WriteLine("Displaying the arraay elements using index");
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine("Displaying the array elements using for loop");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Displaying the array elements using foreach");
            foreach(string s in array)
            {
                Console.WriteLine(s);
            }


        }
    }
}
