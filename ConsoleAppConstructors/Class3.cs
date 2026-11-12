using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConstructors
{
    internal class Class3
    {
        static void Main (string[] args)
        {
            Emply emp1 = new Emply();
            emp1.GetEmply();

            Emply emp2 = new Emply();
            emp2.GetEmply();

            Emply emp3 = new Emply(112,"def",60000);
            emp3.GetEmply();

            Emply emp4 = new Emply(113,"pqr",50000);
            emp4.GetEmply();
        }
    }
}
