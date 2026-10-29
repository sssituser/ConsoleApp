using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    /*
     * Write a program to list all Palindromes, Armstrongs, and Perfects for the given range.
     * 
     * AM : public static
     * PM : two integers start and end values
     * RT : string
     * MN : GetAllNumbers
     */
    internal class Class7
    {

        public static string GetAllNumbers(int start, int end)
        {

          return $"{Class10.GetPalindromes(start,end)}\n{Class11.GetArmstrongs(start,end)}\n{Class11.GetPerfects(start,end)}";
           
        }

        static void Main (string[] args)
        {
            Console.WriteLine(GetAllNumbers(1,1000));
        }
    }
}
