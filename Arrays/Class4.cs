using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class4
    {
        static void Main (string[] args)
        {
            int[] array = new int[3] {45,67,89 };  // Initilization

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine("============Displaying the Elements using for loop============");
            for(int i=0;i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Displaying the Eelements using foreach loop");
            foreach(int k in array)
            {
                Console.WriteLine(k);
            }
        }
    }
}
