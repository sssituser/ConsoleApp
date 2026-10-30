using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    /*
     * Write a program to get maximum number from the given array.
     * Example : {123,456,789,211,520,432}
     *             
     *             {3  , 6 ,   9 ,  2 ,  5 , 4}
     *             {9,6,5,4,3,2}
     *             965432
     *             
     * Maximum Number : 965432
     * 
     * Steps : 1 . Given Array
     *         2 . GetMaxDigitArray
     *         3 . SortArrayInDesc
     *         4 . ArrayToNumber
     *   AM : public static
     *   RT : int
     *   PM : int[]
     *   MN : GetMaxNumber
     *   
     *   AM : pubic static
     *   RT : Int[]
     *   PM : Int[]
     *   MN : GetMaxDigitArray
     *   
     *   AM :  public static
     *   RT :  int[]
     *   PM :  int[]
     *   MN : SortArrayDesc
     *   
     *   AM : public static
     *   RT : int
     *   PM : int[]
     *   MN : ArrayToNumber
     *   AM : public static
     *   RT : int
     *   PM : int
     *   MN : GetMaxDigit
     */
    internal class Class13
    {
        public static int GetMaxDigit(int num)
        {
            int max = num % 10;
            while (num > 0)
            {
                int digit = num % 10;
                if (digit > max)
                {
                    max = digit;
                }
                num = num / 10;
            }
            return max;
        }
        public static int ArrayToNum (int[] array)  // {5,6,7}
        {
            int res = 0;
            foreach(int i in array)
            {
                res = res * 10 + i; //  res = 567
            }
            return res;
        }
        public static int[] SortArrayInDesc (int[] array)
        {
            return array.OrderByDescending (x => x).ToArray ();
        }

        public static int[] GetMaxDigitArray (int[] array) //{123,456}
        {
            int[] MaxDigitArray = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                MaxDigitArray[i] = GetMaxDigit(array[i]);
            }
            return MaxDigitArray;

        }
        public static int GetMaxNumber (int[] array)
        {
                   return  ArrayToNum(SortArrayInDesc(GetMaxDigitArray(array)));
        }
        static void Main (string[] args)
        {
            int[] array = { 123, 456, 789, 211, 520, 432 };


            Console.WriteLine(GetMaxNumber(array));
        }
    }
}
