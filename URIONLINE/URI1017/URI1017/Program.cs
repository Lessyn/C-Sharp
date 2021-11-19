using System;
using System.Globalization;

namespace URI1017
{
    class Program
    {
        static void Main(string[] args)
        {
            double tpgasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vlmedia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double litros = (vlmedia / 12) * tpgasto;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
