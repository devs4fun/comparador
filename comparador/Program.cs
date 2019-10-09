using System;

namespace comparador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparador de inteiros!");

            Console.WriteLine("Insira o primeiro inteiro:");
            Int32 n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o segundo inteiro");
            Int32 n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("Os numeros sao iguais!");
            }
            else
            {
                if (n1 > n2)
                {
                    Console.WriteLine(n1 + " é maior!");
                }
                else
                {
                    Console.WriteLine(n2 + " é maior!");
                }
            }
        }
    }
}
