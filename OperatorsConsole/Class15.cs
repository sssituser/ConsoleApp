using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class Class15
    {
        static void Main (string[] args)
        {
            Console.Write("Enter subjet - 1 Marks : "); 
            int sub1 = int.Parse(Console.ReadLine()); // 40

            Console.Write("Enter subjet - 2 Marks : ");
            int sub2 = int.Parse(Console.ReadLine()); // 50

            Console.Write("Enter subjet - 1 Marks : "); 
            int sub3 = int.Parse(Console.ReadLine()); //60

          string res =  sub1 > 34 && sub2 > 34 && sub3 > 34 ? "Passed" : "Failed";
            Console.WriteLine($"Result is : {res}");
        }
    }
}
