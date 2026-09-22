using System;


namespace ConditionalStatements
{
    internal class Class2
    {
        static void Main (string[] args)
        {
            Console.Write("Enter boolean value : ");
            bool con = bool.Parse(Console.ReadLine());
            if (con)
            {
                Console.WriteLine("Hi Iam Simple if statement");
                Console.WriteLine("Hi Iam using block");
                Console.WriteLine("Hi Iam Inside the block");
            }
         
            Console.WriteLine("Hi check is done");

        }
    }
}
