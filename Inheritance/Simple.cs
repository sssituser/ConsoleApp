using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Simple : ITest
    {
        int num1,num2;
        public void ReadTwoNumbers ()
        {
            Console.Write("Enter num1 : ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter num2 : ");
            num2 = int.Parse(Console.ReadLine());
        }
        public void ShowNumber ()
        {
            Console.WriteLine($"Entered Number are  num1 : {num1}  num2 : {num2}  ");
        }
        public void Sum ()
        {
            Console.WriteLine($"Sum is : {num1+num2}");
        }
        public void Sub ()
        {
            Console.WriteLine($"Sub is : {num1 - num2}");
        }
    }
}
