using System;
using System.Globalization;


namespace URI1018_B
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTAS :");

            Console.WriteLine("{0}", Math.Floor(n / 100) + " nota(s) de R$ 100.00");
            n = n % 100;

            Console.WriteLine("{0}", Math.Floor(n / 50) + " notas(s) de R$ 50.00");
            n = n % 50;

            Console.WriteLine("{0}", Math.Floor(n / 20) + " nota(s) de R$ 20.00");
            n = n % 20;

            Console.WriteLine("{0}", Math.Floor(n / 10) + " nota(s) de R$ 10.00");
            n = n % 10;

            Console.WriteLine("{0}", Math.Floor(n / 5) + " nota(s) de R$ 5.00");
            n = n % 5;

            Console.WriteLine("{0}", Math.Floor(n / 2) + " nota(s) de R$ 2.00");
            n = n % 2;

            Console.WriteLine("MOEDAS :");

            Console.WriteLine("{0}", Math.Floor(n / 1) + " moeda(s) de R$ 1.00");
            n = n % 1;

            Console.WriteLine("{0}", Math.Floor(n / 0.50) + " moeda(s) de R$ 0.50");
            n = n % 0.50;

            Console.WriteLine("{0}", Math.Floor(n / 0.25) + " moeda(s) de R$ 0.25");
            n = n % 0.25;

            Console.WriteLine("{0}", Math.Floor(n / 0.10) + " moeda(s) de R$ 0.10");
            n = n % 0.10;

            Console.WriteLine("{0}", Math.Floor(n / 0.05) + " moeda(s) de R$ 0.05");
            n = n % 0.05;

            Console.WriteLine("{0}", Math.Floor(n / 0.01) + " moeda(s) de R$ 0.01");



        }
    }
}
