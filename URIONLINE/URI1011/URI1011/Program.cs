using System;
using System.Globalization;

namespace URI1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volume = (4.0 / 3.0) * pi * raio * raio * raio;

            Console.WriteLine("VOLUME = "+volume.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
