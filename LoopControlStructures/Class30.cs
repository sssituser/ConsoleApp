using System;


namespace LoopControlStructures
{
    internal class Class30
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            for(int start = 1; start <= 10; start += 1)
            {
                Console.WriteLine($"{num} x {start} = {num*start}");
            }
            
        }
    }
}


 