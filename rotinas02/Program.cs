using System;

namespace Rotinas02

{
    class Program

    {
        static void Main(string[] args)

        {
            Console.Clear();
            double lado1 = 3, lado2 = 4, lado3 = 8;

            if (!ExisteTriangulo(lado1, lado2, lado3))
            {
Console.WriteLine("Não é triangulo");
            }
            else
            {
Console.WriteLine("É triangulo");

            }

            Console.WriteLine();
        }

        static bool ExisteTriangulo(double a, double b, double c)
        {
            bool trianguloValido = (
            a > 0 && b > 0 && c > 0
            && a < (b + c)
            && b < (a + c)
            && c < (a + b)
            && a > Math.Abs(b - c)
            && b > Math.Abs(a - c)
            && c > Math.Abs(a - b)
            );
            return trianguloValido;
        }

    }
}
