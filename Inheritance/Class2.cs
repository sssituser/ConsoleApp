using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class2
    {
        static void Main (string[] args)
        {
            BasicCalcy bc = new BasicCalcy();
            bc.Sum(4, 2);
            bc.Sub(4, 2);
            bc.Mul(4, 2);
            bc.Div(4, 2);
        }
    }
}
