using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class7
    {
        static void Main (string[] args)
        {
            int[] array = new int[4];


            Console.WriteLine("Enter Array Elements");

            for(int i=0; i<array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("===Array elements are=====");
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine("====Array elements using for loop===");

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("==========Array elements using foreach===");
            foreach(int k in array)
            {
                Console.WriteLine(k);
            }



        }
    }
}
