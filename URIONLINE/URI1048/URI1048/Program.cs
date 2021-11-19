using System;
using System.Globalization;

namespace URI1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double reajuste = new double();
            int percentual = new int();

            switch (salario)
            {
                case (< 400.01):
                    percentual = 15;
                    reajuste = (salario * percentual) / 100;
                    salario += (salario * percentual) / 100;

                    break;

                case (< 800.01):
                    percentual = 12;
                    reajuste = (salario * percentual) / 100;
                    salario += (salario * percentual) / 100;

                    break;

                case (< 1200.01):
                    percentual = 10;
                    reajuste = (salario * percentual) / 100;
                    salario += (salario * percentual) / 100;

                    break;

                case (< 2000.01):
                    percentual = 7;
                    reajuste = (salario * percentual) / 100;
                    salario += (salario * percentual) / 100;

                    break;

                case (> 2000.00):
                    percentual = 4;
                    reajuste = (salario * percentual) / 100;
                    salario += (salario * percentual) / 100;

                    break;
            }
            Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: {0} % ", percentual);
        }
    }
}

