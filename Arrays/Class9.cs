using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    // Language Integrated query
    internal class Class9
    {
        static void Main (string[] args)
        {
            int[] array = { 45, 67, 89, 23, 66, 44, 88, 99 };
            
            Console.WriteLine($"Sum of Array elements : {array.Sum()}");
            Console.WriteLine($"Max of Array elements : {array.Max()}");
            Console.WriteLine($"Min of Array elements : {array.Min()}");
            Console.WriteLine($"Average of the array elements : {array.Average()}");
            Console.WriteLine("========Array elements==========");
            
            foreach(int i in array ) 
                Console.WriteLine(i);
                    
            int[] ascarray = array.OrderBy ( element=>element ).ToArray();
          
            
            Console.WriteLine("========Array elements In Ascending Order==========");
            foreach (int i in ascarray)
            {
                Console.WriteLine(i);
            }

            int[] descarray = array.OrderByDescending(element => element).ToArray();
            
            Console.WriteLine("========Array elements In Descending Order==========");
            foreach (int i in descarray)
            {
                Console.WriteLine(i);
            }



        }
    }
}
