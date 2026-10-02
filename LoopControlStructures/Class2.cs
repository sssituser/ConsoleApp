using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    // 2 ,4,6,8, to 20
    // 3 , 6 ,9.... 30
    // 4 , 8 , 12  ..40
    internal class Class2
    {
        static void Main (string[] args)
        {
            int start = 2;
            int end = 20;
            do//2<=20-T 4<=20-T
            {
                Console.WriteLine(start);//2 4
                start = start + 2;//4 6
            } while (start <= end);
        }
    }
}
