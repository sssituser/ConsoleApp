using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class4
    {
        static void Main (string[] args)
        {
            Console.Write("Enter Sub-1 Marks : ");
            int num1 = int.Parse(Console.ReadLine()); // 30
            Console.Write("Enter Sub-2 Marks : ");
            int num2 = int.Parse(Console.ReadLine()); // 40

            Console.Write("Enter Sub-3 Marks : ");
            int num3 = int.Parse(Console.ReadLine()); //50

            if(num1>34 && num2>34  && num3 > 34)
            {
                Console.WriteLine("Student got passed");
            }

            if(num1<35 || num2<35 || num3 < 35)
            {
                Console.WriteLine("Student Got Failed");
            }
        }
    }
}
