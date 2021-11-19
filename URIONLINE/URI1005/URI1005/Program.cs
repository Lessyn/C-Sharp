using System;
using System.Globalization;

namespace URI1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine(), ("{0.0}", CultureInfo.InvariantCulture));
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a * 3.5 + b * 7.5) / 11;

            Console.WriteLine("MEDIA = " +media.ToString("F5", CultureInfo.CurrentCulture));
                
        }
    }
}
