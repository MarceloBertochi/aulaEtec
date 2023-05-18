using System;

namespace RotinaString

{
    class Program

    {
        static void Main(string[] args)

        {
            string nome, sobrenome;

            Console.Clear();
            Console.Write("digite seu nome..: ");
            nome = Console.ReadLine();
            Console.WriteLine();


            Console.Write("digite seu sobrenome..: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine();

            string resultado = ConcatenarTexto(nome, sobrenome);

            Console.WriteLine(resultado);

        }
        static string ConcatenarTexto(string texto1, string texto2)
        {
            string SomaDosTextos = texto1 + " " + texto2;
            return SomaDosTextos;
        }
    }
}

/*
static string MeuNome()
        {
            string MeuNome = "Marcelo Bertochi";
            return MeuNome;
        }
*/


