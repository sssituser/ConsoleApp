using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class Class13
    {
        static void Main (string[] args)
        {
            bool con = true;
            string res1 =  con ? "Welcome" : "Grand Welcome";
            int res2 = con ? 100 : 200;
            double res3 = con ? 6.7 : 8.9;
            Console.WriteLine($"res1 = {res1}\tres2 = {res2}\tres3 = {res3}");
        }
    }
}
