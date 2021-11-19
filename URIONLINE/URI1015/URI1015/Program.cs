using System;
using System.Globalization;

namespace URI1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            double x1 = double.Parse(line[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(line[1], CultureInfo.InvariantCulture);

            line = Console.ReadLine().Split(' ');

            double x2 = double.Parse(line[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(line[1], CultureInfo.InvariantCulture);

            double p1 = Math.Pow(x2-x1,2);
            double p2 = Math.Pow(y2-y1,2); ;

            double distancia = (Math.Sqrt(p1 + p2));

            Console.WriteLine("{0}",distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
