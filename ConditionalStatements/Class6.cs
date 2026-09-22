using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class6
    {
        static void Main (string[] args)
        {
            Console.Write("Enter boolean value : ");
            bool con = bool.Parse(Console.ReadLine ());  // true 
            if (con)
            {
                Console.WriteLine("hi stmt1");
            }
            else
            {
                Console.WriteLine("bye stmt2");
            }

            Console.WriteLine("checking is done");
        }
    }
}
