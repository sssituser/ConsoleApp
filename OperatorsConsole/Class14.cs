using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class Class14
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a string : ");
            string s = Console.ReadLine();

            Console.Write("Enter a Integr value : ");
            int i = int.Parse(Console.ReadLine());

            Console.Write("Enter a float value : ");
            float f = float.Parse(Console.ReadLine());

            Console.Write("Enter a double value : ");
            double d = double.Parse(Console.ReadLine());
            //Reading completed

            Console.WriteLine($"{s}  {i}  {f}  {d}");
            Console.WriteLine($"s = {s} i = {i}  f = {f} d = {d}");

        }
    }
}
