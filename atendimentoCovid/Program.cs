using System;

namespace AtendimentoCovid

{ 
    class Program

    {
        static void Main(string[] args)

        {
            int idade;

            Console.Clear();
            Console.WriteLine("-- Triagem para Covid19 --");
            Console.WriteLine("\nAdaptado do Site da Saúde");
            Console.WriteLine("Resultado estritamente educacional, procure ajuda especializada\n".ToUpper());
            
            Console.WriteLine("Qual a idade do paciente");
            bool idadeNumerica = Int32.TryParse(Console.ReadLine(), out idade);

            if (!idadeNumerica || idade < 0 || idade > 130)

            {
                Console.WriteLine("idade inválida");
                Environment.Exit(-1); // vai fechar o programa por erro 
            }


            Console.WriteLine("Obrigado!");







            

        }
    }
}

