using System;
using System.Globalization;

namespace URI1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            int CodPeca1 = int.Parse(line1[0]);
            int QtdPeca1 = int.Parse(line1[1]);
            double VrPeca1 = double.Parse(line1[2], CultureInfo.InvariantCulture);

            string[] line2 = Console.ReadLine().Split(' ');
            int CodPeca2 = int.Parse(line2[0]);
            int QtdPeca2 = int.Parse(line2[1]);
            double VrPeca2 = double.Parse(line2[2], CultureInfo.InvariantCulture);

            double Total = (QtdPeca1 * VrPeca1) + (QtdPeca2 * VrPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
