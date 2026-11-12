using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStaticMembers
{
    internal class Class2
    {
        static void Main (string[] args)
        {
            Cricket.GetTotalScore();
            Cricket p1 = new Cricket();
           
            p1.SetPlayerInfo("virat", 50);
            p1.GetPlayerInfo();

            Cricket p2 = new Cricket();
            p1.SetPlayerInfo("Rohit", 72);
            p1.GetPlayerInfo();

        }
    }
}
