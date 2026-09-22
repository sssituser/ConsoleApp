using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class8
    {

        static void Main (string[] args)
        {
            Console.Write("Enter User Name :");
            string uname = Console.ReadLine();  // admin

            Console.Write("Enter Password : ");
            string pwd = Console.ReadLine(); // admin
            if (uname == "admin" && pwd == "admin")
            {
                Console.WriteLine("Login Success");
            }
            else
            {
                Console.WriteLine("Invalid Credentials");
            }

        }
    }
}
