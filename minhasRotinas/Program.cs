using System;

namespace ElaborandoMinhasRotinas

{
    class Program

    {
        static void Main(string[] args)

        {
            LimparTela();
            MinhaAssinatura();
            ResetarCor();
        }

        static void MinhaAssinatura()
        {
            LinhaAmarela();
            BarraAmarelaInicio();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" Trabalho para Nota do Aluno ");
            BarraAmarelaFinal();
            BarraAmarelaInicio();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" Marcelo Camara Bertochi ");
            BarraAmarelaFinal2();
            BarraAmarelaInicio();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" Curso Informática I - Noite ");
            BarraAmarelaFinal();
            LinhaAmarela();
        }

        static void LinhaAmarela()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("-------------------------------\n");
            Console.ResetColor();
        }

        static void BarraAmarelaInicio()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("|");
            Console.ResetColor();
        }
        static void BarraAmarelaFinal()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("|\n");
            Console.ResetColor();
        }

        static void BarraAmarelaFinal2()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("|\n".PadLeft(6, ' '));
            Console.ResetColor();
        }
        static void ResetarCor()
        {
            Console.ResetColor();
        }

        static void LimparTela()
        {
            Console.Clear();
        }

    }
}
