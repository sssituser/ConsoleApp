using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings
{
    internal class Class4
    {
        static void Main (string[] args)
        {
            string name = "WelcomeToSSSIT";
            Console.WriteLine(name);
            Console.WriteLine(name.Substring(0,7));
            Console.WriteLine(name.Substring(7,2));
            Console.WriteLine(name.Substring(9));
        }
    }
}
