using System;

namespace LoopControlStructures
{
    internal class Class27
    {
        //Write program to generates numbers from to 1,3,5,7,9,11...upto 20
        static void Main (string[] args)
        {
            for(int start = 1;start<=20; start = start + 2) //start = 1;3<=20-T
            {
                Console.WriteLine(start); //1 3 5 7 9 11 13 15 17 19
            }
        }
    }
}
