using System;
using System.Collections.Generic;

namespace URI1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int n1 = int.Parse(numeros[0]);
            int n2 = int.Parse(numeros[1]);
            int n3 = int.Parse(numeros[2]);

            List<int> lista = new List<int>();
            lista.Add(n1);
            lista.Add(n2);
            lista.Add(n3);
            lista.Sort();

            foreach (int item in lista)
                Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
        }
    }
}
