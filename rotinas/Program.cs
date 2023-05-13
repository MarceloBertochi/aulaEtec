using System;

namespace Rotinas

{
    class Program

    {
        static void Main(string[] args)

        {
            ExibirHoraAtual();
            AguardarUsuario("Digite uma tecla");
            ExibirHoraAtual();
            AguardarUsuario("Digite uma outra tecla");
            ExibirHoraAtual();
        }

        void ExibirHoraAtual() // rotina para exibir a hora atual 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.ResetColor();
        }

        void AguardarUsuario(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadKey(); // somente espera qualquer tecla ser acionada.
        }
    }
}