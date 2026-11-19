using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Result :Tesla, IA,IB
    {
        public void Rem ()
        {
            Console.WriteLine($"Rem is : {num1%num2}");
        }
        public void Sum ()
        {
            Console.WriteLine($"Sum is : {num1+num2}");
        }
        public void Sub ()
        {
            Console.WriteLine($"Sub is : {num1-num2}");
        }
        public void Mul ()
        {
            Console.WriteLine($"Mul is : {num1*num2}");
        }
        public void Div ()
        {
            Console.WriteLine($"Quo is : {num1/num2}");
        }
    }
}
