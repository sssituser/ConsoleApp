using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class Class6
    {
        static void Main (string[] args)
        {
            int s = 5;
            Console.WriteLine($"Area of a squarae : {s*s} mtsq");
            int l = 6, b = 5;
            Console.WriteLine($"Area of a Rectangle is : {l*b} mtsq");
            double r = 4.2;
            Console.WriteLine($"Area of a Circle is : {3.14*r*r}");
        }
    }
}
