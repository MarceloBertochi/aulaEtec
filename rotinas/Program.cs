using System;

namespace Rotinas

{
    class Program

    {
        static void Main(string[] args)

        {
            //ExibirHoraAtual();
            //AguardarUsuario();
            //ExibirHoraAtual();
            //AguardarUsuario("Digite uma outra tecla");
            //ExibirHoraAtual();
            Console.Clear();

            //string nome;
            //Console.Write("Digite seu nome......:");
            //nome = Console.ReadLine();

            //string sobrenome;
            //Console.Write("Digite seu sobrenome.:");
            //sobrenome = Console.ReadLine();

            string nome = LerString("Nome..:");
            string sobrenome = LerString("Sobrenome..:");

            Console.WriteLine();

            string nomeCompleto = ObterNomeCompleto(nome, sobrenome);

            Console.WriteLine($"Bem vindo {nomeCompleto}\n");
            Console.WriteLine($"Volte sempre {nomeCompleto}");

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

        static string ObterNomeCompleto(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }

        static string LerString(string mensagem)
        {
            Console.Write(mensagem);
            string ValorDigitado = Console.ReadLine();
            return ValorDigitado;
        }
    }
}