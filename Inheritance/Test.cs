using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Test:Sample
    {
        public void Hello ()
        {
            Console.WriteLine("Hi Iam hello method from class Test");
        }
        public void Morning ()
        {
            Console.WriteLine("Hi Iam morning method from class Test");
        }
    }
}
