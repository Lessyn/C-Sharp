using System;
using System.Globalization;

namespace URI1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            double A = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            double B = double.Parse(numeros[1], CultureInfo.InvariantCulture);
            double C = double.Parse(numeros[2], CultureInfo.InvariantCulture);


            if ((A < B + C) && (B < A + C) && (C < A + B))
            {
                double resultado = A + B + C;
                Console.WriteLine("Perimetro = " + resultado.ToString("F1", CultureInfo.InvariantCulture));

            }
            else
            {
                double resultado = ((A + B) * C) / 2.0;
                Console.WriteLine("Area = " + resultado.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
