using System;
using System.Globalization;

namespace URI1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int resp = 0;

            Console.WriteLine("NOTAS:");

            resp = (int)n / 100;
            Console.WriteLine(resp + " nota(s) de R$ 100.00");
            n = n % 100.0;

            resp = (int)n / 50;
            Console.WriteLine(resp + " nota(s) de R$ 50.00");
            n = n % 50.0;

            resp = (int)n / 20;
            Console.WriteLine(resp + " nota(s) de R$ 20.00");
            n = n % 20.0;

            resp = (int)n / 10;
            Console.WriteLine(resp + " nota(s) de R$ 10.00");
            n = n % 10.0;

            resp = (int)n / 5;
            Console.WriteLine(resp + " nota(s) de R$ 5.00");
            n = n % 5.0;

            resp = (int)n / 2;
            Console.WriteLine(resp + " nota(s) de R$ 2.00");
            n = n % 2.0;

            Console.WriteLine("MOEDAS:");

            n = n * 100.0;

            resp = (int)n / 100;
            Console.WriteLine(resp + " moeda(s) de R$ 1.00");
            n = n % 100.0;

            resp = (int)n / 50;
            Console.WriteLine(resp + " moeda(s) de R$ 0.50");
            n = n % 50.0;

            resp = (int)n / 25;
            Console.WriteLine(resp + " moeda(s) de R$ 0.25");
            n = n % 25.0;

            resp = (int)n / 10;
            Console.WriteLine(resp + " moeda(s) de R$ 0.10");
            n = n % 10.0;

            resp = (int)n / 5;
            Console.WriteLine(resp + " moeda(s) de R$ 0.05");
            n = n % 5.0;

            resp = (int)n / 1;
            Console.WriteLine(resp + " moeda(s) de R$ 0.01");
            n = n % 1.0;
        }
    }
}
