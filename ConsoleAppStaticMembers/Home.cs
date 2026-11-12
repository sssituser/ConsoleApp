using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStaticMembers
{
    internal class Home
    {
        public static int CapitalAmount = 10000;

        public void ShowBalance ()
        {
            Console.WriteLine($"Amount Present in the Home : {CapitalAmount}");
        }
        public void Spent ()
        {
            Console.Write("Enter Amount to Spent : ");
            int amount = int.Parse(Console.ReadLine() );
            CapitalAmount = CapitalAmount - amount;
            Console.WriteLine($"After Spending the Amount Balance Left is : {CapitalAmount}");
        }
    }
}
