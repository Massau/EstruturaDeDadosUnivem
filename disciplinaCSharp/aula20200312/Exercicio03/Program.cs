using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Tabuada do número:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Deseja ver a tabuada até o número:");
            double multiplicando = int.Parse(Console.ReadLine());

            for (int i = 0; i <= multiplicando; i++)
            {
                Console.WriteLine($"{numero} X {i} = {numero * multiplicando}");  
            }
        }
    }
}
