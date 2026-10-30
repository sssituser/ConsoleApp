using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    /*
     * Write a program to find the namescore of given string
     * input : abc   ouput : 6
     * input : zyx   output: 26+25+24=>75
     * MN : GetNameScore
     * AM : public static
     * PM : string
     * RT : int
     * 
     * Write program to Encrpyt the given name
     * input : abc   Ans : zyx
     * input : arun  Ans : zifm
     * MN : Encrpyt
     * AM : public static
     * PM : string
     * RT : string
     */
    internal class Class12
    {  

        //AM RT MN(PM)
        public static string Encrpyt(string name) 
        {
            name = name.ToLower();
            string alphabets  = " abcdefghijklmnopqrstuvwxyz";
          
            string res = string.Empty;
            foreach (char ch in name) // "abc"
            {
                res +=alphabets.ElementAt(27-alphabets.IndexOf(ch));
            }
            return res;
        }
        public static int GetNameScore(string name) 
        {
            name = name.ToLower();
            string alphabets = " abcdefghijklmnopqrstuvwxyz";
            int sum = 0;
            foreach(char ch in name) 
            {
                sum +=  alphabets.IndexOf(ch); 
            }
            return sum;
        }
        static void Main (string[] args)
        {
            string name = "abc";
            Console.WriteLine($"{name} Name Score is : {GetNameScore(name)}");
            name = "ABC";
            Console.WriteLine($"{name} Name Score is : {GetNameScore(name)}");
            name = "Suguna Reddy";
            Console.WriteLine($"{name} Name Score is : {GetNameScore(name)}");
            name = "Jaya Simha Prasad";
            Console.WriteLine($"{name} Name Score is : {GetNameScore(name)}");
            name = "Arun Kumar";
            Console.WriteLine($"{name} Name Score is : {GetNameScore(name)}");

            name = "abc";
            Console.WriteLine($"{name} Name Encryption is : {Encrpyt(name)}");
            name = "ARUN";
            Console.WriteLine($"{name} Name Encryption is : {Encrpyt(name)}");
            name = "ZYX";

            Console.WriteLine($"{name} Name Encryption is : {Encrpyt(name)}");

        }
    }
}
