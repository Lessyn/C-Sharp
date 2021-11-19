using System;
using System.Globalization;

namespace URI1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consuno = x / y;

            Console.WriteLine("{0} km/l", consuno.ToString ("F3", CultureInfo.InvariantCulture));
        }
    }
}
