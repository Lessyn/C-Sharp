using System;
using System.Globalization;

namespace URI1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] item = Console.ReadLine().Split(' ');
            double total;
            int codigo = int.Parse(item[0]);
            int qtde = int.Parse(item[1]);

            if (codigo == 1)
            {
                total = qtde * 4.00;
                Console.WriteLine("Total: R$ " +total.ToString("F2", CultureInfo.InvariantCulture));
            }
            if (codigo == 2)
                {
                    total = qtde * 4.50;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                }
            if (codigo == 3)
            {
                total = qtde * 5.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            if (codigo == 4)
            {
                total = qtde * 2.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            if (codigo == 5)
            {
                total = qtde * 1.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
