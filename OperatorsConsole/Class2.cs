using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class Class2
    {
        static void Main (string[] args)
        {
            Console.WriteLine("================Conversion From Kgs to Gms=====================");
            Console.Write("Enter Weight in Kgs : ");
            float kg = float.Parse(Console.ReadLine());
            Console.WriteLine($"Entered {kg} Kgs is  : {1000*kg} gms");
            Console.WriteLine("================Conversion From GMS to KGS=====================");
            Console.Write("Enter Weigth in gms : ");
            float gms = float.Parse(Console.ReadLine());
            Console.WriteLine($"Enterted {gms} gms is in {gms/1000} kg ");
           





        }
    }
}
