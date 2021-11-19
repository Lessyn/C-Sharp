using System;
using System.Globalization;

namespace URI1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            double n1 = double.Parse(line[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(line[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(line[2], CultureInfo.InvariantCulture);
            double n4 = double.Parse(line[3], CultureInfo.InvariantCulture);

            double media = Math.Floor(n1 * 2.0 + n2 * 3.0 + n3 * 4 + n4 * 1) / 10;

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                double notaexame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaexame.ToString("F1", CultureInfo.InvariantCulture));
                double notafinal = (notaexame + media) / 2;
                if (notafinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + notafinal.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + notafinal.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
            else if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
