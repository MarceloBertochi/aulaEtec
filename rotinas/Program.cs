using System;

namespace Rotinas

{
    class Program

    {
        static void Main(string[] args)

        {
            Program.exibirHoraAtual();

            Console.WriteLine("Digite uma tecla...:");
            Console.ReadKey(); // somente espera qualquer tecla ser acionada. 

            Program.exibirHoraAtual();
        }

        static void exibirHoraAtual() // rotina para exibir a hora atual 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.ResetColor();
        }
    }
}