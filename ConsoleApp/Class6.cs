using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("byte        ====        {sizeof(byte)} byte");
            Console.WriteLine($"byte        ====       {sizeof(byte)} byte");
            Console.WriteLine($"sbyte       ====       {sizeof(sbyte)} byte");
            Console.WriteLine($"short       ====       {sizeof(short)} bytes");
            Console.WriteLine($"int         ====       {sizeof(int)} bytes");
            Console.WriteLine($"long        ====       {sizeof(long)} bytes");
            Console.WriteLine($"float       ====       {sizeof(float)} bytes");
            Console.WriteLine($"double      ====       {sizeof(double)} bytes");
            Console.WriteLine($"decimal     ====       {sizeof(decimal)} bytes");
            Console.WriteLine($"char        ====       {sizeof(char)} bytes");
            Console.WriteLine($"bool        ====       {sizeof(bool)} bytes");
        }
    }
}
