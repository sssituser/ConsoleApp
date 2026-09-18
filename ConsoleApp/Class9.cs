using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            string name = "abc";    // string is data type  , name is  variable  , "abc" is value
            int num1 = 56;          //  int is data type, num1 is variable , 56 is a value
            double d = 6.7;        //   double is a data type , d is a variable, 6.7 is a value
            bool bl = true;       //     bool is a data tyes, bl is a variable, true is a value
            Console.WriteLine(name);
            Console.WriteLine(num1);
            Console.WriteLine(d);
            Console.WriteLine(bl);

            Console.WriteLine($"{name}  {num1}   {d}   {bl}");
        }
    }
}
