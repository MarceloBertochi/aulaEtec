int n = 10;
n = n +5;

string nomeUsuario;

Console.WriteLine("Digite seu nome");
nomeUsuario = Console.ReadLine()!;

DizerOi(nomeUsuario);
Console.WriteLine("hahahahahahaha");
DizerTchau(nomeUsuario);

void DizerOi(string nome)
{
    Console.WriteLine($"Oi, {nome}");
}

void DizerTchau(string nome)
{
        
       Console.WriteLine($"Tchau, {nome}");

}

// ok
