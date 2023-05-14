using System;

namespace Rotinas02

{
    class Program

    {
        static void Main(string[] args)

        {
            Console.Clear();
            double lado1 = 3, lado2 = 3, lado3 = 3;

            if (!ExisteTriangulo(lado1, lado2, lado3))
            {
                Console.WriteLine("Não é triangulo");
            }
            else
            {
                // função dizendo que é triangulo
                string tipo = TipoTriangulo(lado1, lado2, lado3);
                double area = AreaTriangulo(lado1, lado2, lado3);

                Console.WriteLine($"O triângulo ({lado1}, {lado2}, {lado3}) é {tipo} e possui área de {area:N3}.");
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

        static string TipoTriangulo(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "equilátero";
            }
            else if (a != b && b != c && c != a)
            {
                return "escaleno";
            }
            else 
            {
                return "isóceles";
            }
        }

static double AreaTriangulo(double a, double b, double c)
{
    double s = (a + b + c) / 2;

    return Math.Sqrt(s * (s - a)*(s - b)*(s - c));
}

    }
}


        