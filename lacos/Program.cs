
using System;

namespace Laços

{
    class Program

    {
        static void Main(string[] args)

        {

           string opcao = "";
            while (opcao != "X")
            {
                Console.WriteLine("OI");
                Console.Write("dESEJA CONSINUAR");
                opcao = Console.ReadLine()!;

                Console.WriteLine($"voce digitou [{opcao}]");
            }


        }
    }
}

/*
 Console.Clear();
            int contador = 1;
            const int max = 10;

             Console.WriteLine("Inicio da execução");

            while (contador <= 10)

            {
                Console.WriteLine($"Execução # {contador}");
                Thread.Sleep(1500);
                contador = contador + 1;
            }

            Console.WriteLine("Fim da execução");
*/
