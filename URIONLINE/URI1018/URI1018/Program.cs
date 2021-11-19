using System;

namespace URI1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i100, i50, i20, i10, i5, i2, i1;

            Console.WriteLine(n);

            for (i100 = 0; n > 99; i100++)

            {
                n = n - 100;

            }

            for (i50 = 0; n > 49; i50++)

            {
                n = n - 50;

            }

            for (i20 = 0; n > 19; i20++)

            {
                n = n - 20;

            }

            for (i10 = 0; n > 9; i10++)

            {
                n = n - 10;

            }

            for (i5 = 0; n > 4; i5++)

            {
                n = n - 5;

            }

            for (i2 = 0; n > 1; i2++)

            {
                n = n - 2;

            }

            for (i1 = 0; n > 0; i1++)

            {
                n = n - 1;

            }
            
            Console.WriteLine(+i100+ " nota(s) de R$ 100,00");
            Console.WriteLine(+i50+ " nota(s) de R$ 50,00");
            Console.WriteLine(+i20+ " nota(s) de R$ 20,00");
            Console.WriteLine(+i10+ " nota(s) de R$ 10,00");
            Console.WriteLine(+i5+ " nota(s) de R$ 5,00");
            Console.WriteLine(+i2+ " nota(s) de R$ 2,00");
            Console.WriteLine(+i1+ " nota(s) de R$ 1,00");
        }

    }

}

