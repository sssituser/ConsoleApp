using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class IncDecOperator
    {
        /*
         *  ++  Increment operator, It will Increase value by   1 or It will add 1 to the given value.
         *  --  Decrement Operator, It will Reduce the value by  1or It will subtract 1 from the given number
         */
        static void Main (string[] args)
        {
            int num1 = 10;
            Console.WriteLine($"num1 = {num1}");
            ++num1;
            Console.WriteLine($"num1 = {num1}");


        }
    }
}
