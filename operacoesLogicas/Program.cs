using System;

namespace AulaOperacoesLogicas

{
    class Program

    {
        static void Main(string[] args)

        {
            // /vaciáveis Booleanas

            int idade = 18;
            string cnh = "S";           
            

            Console.Write("Digite sua idade..:");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Possui CNH (S/N)..:");
            cnh = (Console.ReadLine()!.ToUpper());


            if (idade >= 18 && cnh == "S")
            {
                Console.WriteLine("CNH Válida");
            }

            else
            { Console.WriteLine("Você não tem idade para obter uma CNH"); }



            //Utilizando Comparações
            //Operador Ternário

            /*
                        //bool p = false, q = false, r = false; // 1
                        //bool p = false, q = true, r = false; // 2
                        //bool p = true, q = false, r = false; // 3
                        //bool p = true, q = true, r = false; // 4
                        //bool p = false, q = false, r = true; // 5
                        //bool p = false, q = true, r = true; // 6
                        //bool p = true, q = false, r = true; // 7
                        //bool p = true, q = true, r = true; // 8




                        Console.WriteLine(!p || q && r);
                        //Console.WriteLine((p || q) && (!r));
                        */
        }
    }
}
