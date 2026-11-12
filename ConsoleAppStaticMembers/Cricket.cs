using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStaticMembers
{
    internal class Cricket
    {
        private static int TotalScore = 0;
        private int PersonalScore = 0;
        private string PlayerName = string.Empty;

        public static void GetTotalScore ()
        {
            Console.WriteLine($"Total Score : {TotalScore}");
        }
        public  void SetPlayerInfo (string pname, int pscore) // virat 50
        {
            PlayerName = pname;
            PersonalScore = pscore;
            TotalScore = TotalScore + pscore;
        }
        public void GetPlayerInfo ()
        {
            
            Console.WriteLine($"Player Name : {PlayerName}   Runs: {PersonalScore}");
            Console.WriteLine($"Total Score : {TotalScore}");
        }

    }
}
