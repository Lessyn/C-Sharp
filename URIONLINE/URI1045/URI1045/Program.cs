using System;
using System.Globalization;

namespace URI1045
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] numeros = Console.ReadLine().Split(' ');
            double X = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            double Y = double.Parse(numeros[1], CultureInfo.InvariantCulture);
            double Z = double.Parse(numeros[2], CultureInfo.InvariantCulture);
            double A, B, C;

            if (X > Y && X > Z)
            {
                A = X;
                B = Y;
                C = Z;
            }
            if (Y > X && Y > Z)
            {
                A = Y;
                B = Z;
                C = X;
            }
            else
            {
                A = Z;
                B = X;
                C = Y;
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }

            else if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");

            }
            else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if (A == B && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (A == B || A == C || B == C)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}