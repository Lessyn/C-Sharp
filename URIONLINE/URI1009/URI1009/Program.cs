using System;
using System.Globalization;

namespace URI1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Tvendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double comissao = (Tvendas * 15) / 100;
            double salariomes = comissao + salario;

            Console.WriteLine("TOTAL = R$ " + salariomes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
