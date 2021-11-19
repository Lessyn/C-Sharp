using System;
using System.Globalization;

namespace URI1036
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double delta = (b * b) - (4.0 * a * c);
            double r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
