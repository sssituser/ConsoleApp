using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; /// Predefined Namespacess  or .dll (Dynamic Link Library or Lib.

namespace OppsConsoleApp   // User defined Namesapce
{
    internal class Program // class Declaration
    {
        static void Main (string[] args) // Method
        {
            Test.fullName = "abc";
            Test.age = 30;
            Test.contactNumber = "99999999999";
            Test.qual = "Graduation";

            Sample.fullName = "def";
            Sample.age = 23;
            Sample.contactNumber = "12345";
            Sample.qual = "PG";

            //Simple.fullName = "pqr"; will get error since the fullname field is proteccted

            Demo.fullName = "lmn";

        }
    }
}
