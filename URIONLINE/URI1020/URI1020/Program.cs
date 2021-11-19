using System;

namespace URI1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tdias = int.Parse(Console.ReadLine());

            int ano = Tdias / 365;
            Tdias = Tdias % 365;

            int meses = Tdias / 30;
            Tdias = Tdias % 30;

            int dia = Tdias;

            Console.WriteLine(+ano+" ano(s)");
            Console.WriteLine(+meses+" mes(es)");
            Console.WriteLine(+dia+" dia(s)");
        }
    }
}
