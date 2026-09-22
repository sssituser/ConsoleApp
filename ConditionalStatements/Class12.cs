using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class12
    {
        static void Main (string[] args)
        {
            Console.Write("Enter Tempareture : ");
            int temp = int.Parse(Console.ReadLine()); // temp = 26
            if (temp > 14)
            {

                if (temp < 26)
                {
                    Console.WriteLine("Its Normal Tempareture");
                }
                else
                {
                    Console.WriteLine("Tempareture is Hot");
                }
            }
            else
            {
                Console.WriteLine("Cool Tempareture");
            }
        }
    }
}
