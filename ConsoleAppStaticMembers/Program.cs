using System;


namespace ConsoleAppStaticMembers
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("===========Brother - 1 Operations===============");
            Home br1 = new Home();
            br1.ShowBalance();
            br1.Spent();
            Console.WriteLine("===========Brother - 2 Operations===============");
            Home br2 = new Home();
            br2.ShowBalance();
            br2.Spent();
          
           
        }
    }
}
