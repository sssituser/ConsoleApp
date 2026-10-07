using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class8
    {
        static void Main (string[] args)
        {
            int[] array = {45,67,89,23,66,44,88,99 };
            Console.WriteLine("Elements before sorting");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Array Elements After Sorting In Ascendng");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int copy = array[i];
                        array[i] = array[j];
                        array[j] = copy;
                    }
                }
            }
            for(int i=0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Array Elements After Sorting In Descendng");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int copy = array[i];
                        array[i] = array[j];
                        array[j] = copy;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
