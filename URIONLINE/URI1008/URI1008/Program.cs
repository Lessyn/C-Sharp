using System;
using System.Globalization;
namespace URI1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int horasT = int.Parse(Console.ReadLine());
            double vrhoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = (horasT * vrhoras);

            Console.WriteLine("NUMBER = " + n);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
