using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    /*
     Write a program to genearte list of Perfect numbers for the given statarting and 
    ending values.

    Write a program to generte list of Armstrong numbers for the given starting and ending values.



    //MN : GetArmstrongs
    //RT : string
    //PM : two integers starting and ending values
    //AM : public static
    
      MN : GetPerfects
      RT : string
      PM : Two Integers starting and ending values
      AM : public staticc
     */

    internal class Class11
    {
        public static string GetArmstrongs (int start, int end)
        {
            string res = string.Empty;
            for (int i = start; i <= end; i++)
            {
                if(Class9.IsArmstrong(i))
                {
                    res += i + ",";
                }
            }
            return $"Armstrong Numbers : {res.Substring(0, res.Length - 1) + "."}";
        }

        public static string GetPerfects (int start, int end)
        {
            string res = string.Empty;
            for (int i = start; i <= end; ++i)
            {
                if (Class8.IsPerfect(i))
                {
                    res += i + ",";
                }
            }
            return $"Perfect Numbers : {res.Substring(0,res.Length-1)+"."}";
        }
        
        
        static void Main (string[] args)
        {
            Console.WriteLine(GetArmstrongs(1,100000));
            Console.WriteLine(GetPerfects(1,100000));
        }
    }
}
