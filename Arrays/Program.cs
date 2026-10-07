using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main (string[] args)
        {
            int[] nums = new int[5];
            nums[0] = 56;
            nums[1] = 67;
            nums[2] = 78;
            nums[3] = 98;
            nums[4] = 56;
            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[1]);
            Console.WriteLine(nums[2]);
            Console.WriteLine(nums[3]);
            Console.WriteLine(nums[4]);

        }
    }
}
