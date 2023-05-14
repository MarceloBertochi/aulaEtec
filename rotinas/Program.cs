using System;

namespace Rotinas

{
    class Program

    {
        static void Main(string[] args)

        {
            ExibirHoraAtual();
            AguardarUsuario();
            ExibirHoraAtual();
            AguardarUsuario("Digite uma outra tecla");
            ExibirHoraAtual();
        }

        static void ExibirHoraAtual() // rotina para exibir a hora atual 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.ResetColor();
        }

        static void AguardarUsuario(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadKey(); // somente espera qualquer tecla ser acionada.
        }

        static void AguardarUsuario()
        {
            AguardarUsuario("Digite uma tecla");
        }
    }
}