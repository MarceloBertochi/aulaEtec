string menu = @"
-=-=- Calculadora -=-=-
Operações:
+ Adição
- Subtração
* Multiplicação
/ Divisão
---
x Sair
Digite a sua opção: ";

string opcao;

do
{
    Console.Clear();

    Console.Write(menu);
    opcao = Console.ReadLine()!.ToLower().Trim();

    switch (opcao)
    {
        case "+":
            ExecutarAdicao();
            break;

        case "-":
            ExecutarSubtracao();
            break;

        case "*":
            ExecutarMultiplicacao();
            break;

        case "/":
            ExecutarDivisao();
            break;

        case "x":
            Console.WriteLine("Finalizando...");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    Console.Write("Digite uma tecla para continuar...");
    Console.ReadKey();
}
while (opcao != "x");

Console.WriteLine("\nTchau!");

void ExecutarAdicao()
{
    Console.WriteLine("Adição");
}

void ExecutarSubtracao()
{
    Console.WriteLine("Subtração");
}

void ExecutarMultiplicacao()
{
    Console.WriteLine("Multiplicação");
}

void ExecutarDivisao()
{
    Console.WriteLine("Divisão");
}