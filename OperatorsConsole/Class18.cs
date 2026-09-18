using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class Class18
    {
        static void Main (string[] args)
        {
            Console.Write("Enter UserName :"); // Admin
            string uname = Console.ReadLine();

            Console.Write("Enter Password :"); //Admin
            string pwd = Console.ReadLine();


            string res = uname == "admin" && pwd == "admin" ? "Login Success..." : "Login Failed";
            Console.WriteLine(res);



        }
    }
}
