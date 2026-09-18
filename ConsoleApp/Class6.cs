using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"byte        ====       {sizeof(byte)} byte\t\t\tMinValue : {byte.MinValue}\t\tMaxValue : {byte.MaxValue}");
            Console.WriteLine($"sbyte       ====       {sizeof(sbyte)} byte\t\t\tMinValue : {sbyte.MinValue}\t\tMaxValue : {sbyte.MaxValue}");
            Console.WriteLine($"short       ====       {sizeof(short)} bytes\t\t\tMinValue : {short.MinValue}\t\tMaxValue : {short.MaxValue}");
            Console.WriteLine($"int         ====       {sizeof(int)} bytes\t\t\tMinValue : {int.MinValue}\t\tMaxValue : {int.MaxValue}");
            Console.WriteLine($"long        ====       {sizeof(long)} bytes\t\t\tMinValue : {long.MinValue}\t\tMaxValue : {long.MaxValue}");
            Console.WriteLine($"float       ====       {sizeof(float)} bytes\t\t\tMinValue : {float.MinValue}\t\tMaxValue : {float.MaxValue}");
            Console.WriteLine($"double      ====       {sizeof(double)} bytes\t\t\tMinValue : {double.MinValue}\t\tMaxValue : {double.MaxValue}");
            Console.WriteLine($"decimal     ====       {sizeof(decimal)} bytes\t\t\tMinValue : {decimal.MinValue}\t\tMaxValue : {decimal.MaxValue}");
            Console.WriteLine($"char        ====       {sizeof(char)} bytes");
            Console.WriteLine($"bool        ====       {sizeof(bool)} bytes");
        }
    }
}
