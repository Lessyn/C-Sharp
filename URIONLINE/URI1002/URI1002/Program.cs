using System;
using System.Globalization;

namespace URI1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double n = 3.14159;
            double raio = double.Parse(Console.ReadLine(),(CultureInfo.InvariantCulture));

            area = n * ( raio * raio);

            Console.WriteLine("A =" + area.ToString("F4", CultureInfo.InvariantCulture));

            
        }
    }
}
