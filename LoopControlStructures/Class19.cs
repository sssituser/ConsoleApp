using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class19
    {
        static void Main (string[] args)
        {
            int num = 1634;
            int sum = 0;
            int powercount = 0;
            int copy = num; // copy = 1634
            // It is counting the digits(power)
            while (num > 0) 
            {
                int digit = num % 10; 
                powercount++; 
                num = num / 10; 
            }


            num = copy; 
      
            
            while (num > 0)  
            {
                int digit = num % 10; 
                int start = 1;
                int pval = 1; 

                // Finding the power of the digits
                while (start <= powercount) 
                {
                    pval = pval * digit; 
                    start++; // 5
                }

                sum = sum + pval; 
                num = num / 10; 
            }
            if (copy == sum)
            {
                Console.WriteLine($"{copy} Is An Armstrong number");
            }
            else
            {
                Console.WriteLine($"{copy} Is Not An Armstrong number");
            }
        }
    }
}
