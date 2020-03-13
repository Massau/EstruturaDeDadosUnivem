using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Avaliacao[] avaliacao = new Avaliacao[10];
            
            for(int i=0; i < avaliacao.Length; i++){

                avaliacao[i] = new Avaliacao();

                Console.WriteLine("Digite a nota da OA");
                avaliacao[i].notaOa = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a nota da PO");
                avaliacao[i].notaPo = Convert.ToDouble(Console.ReadLine());

                avaliacao[i].calcularMedia();
                Console.WriteLine($"Média: {avaliacao[i].media}");
            }
        }
    }
}
