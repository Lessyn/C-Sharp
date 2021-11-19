using System;
using System.Globalization;

namespace URI1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            string[] line = Console.ReadLine().Split(' ');

            double a = double.Parse(line[0], CultureInfo.InvariantCulture);
            double b = double.Parse(line[1], CultureInfo.InvariantCulture);
            double c = double.Parse(line[2], CultureInfo.InvariantCulture);

            double triangulo = a * c / 2;
            double circulo = pi * (c * c);
            double trapezio = (a + b) * c / 2;
            double quadrado = b * b;
            double retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
