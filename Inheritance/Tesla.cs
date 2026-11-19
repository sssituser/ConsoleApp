using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Tesla
    {
       protected int num1, num2;

        public void ReadNums ()
        {
           
            Console.Write("Enter Num1 : ");
             num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Num2 : ");
             num2 = int.Parse(Console.ReadLine());

        }
        public void GetNums ()
        {
            Console.WriteLine($"Num1 : {num1}\tNum2 : {num2}");
        }

    }
}
