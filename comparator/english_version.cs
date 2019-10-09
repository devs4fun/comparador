using System;

namespace comparador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer Comparator!");

            Console.WriteLine("Enter first integer: ");
            Int32 n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second integer:");
            Int32 n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("The numbers are equal!");
            }
            else
            {
                if (n1 > n2)
                {
                    Console.WriteLine(n1 + " is greater!");
                }
                else
                {
                    Console.WriteLine(n2 + " is greater!");
                }
            }
        }
    }
}
