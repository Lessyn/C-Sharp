using System;

namespace URI1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]); 
            int c = int.Parse(line[2]);

            if (a > b && a > c)
            {
                Console.WriteLine(+a + " eh o maior");
            }
            else if (b > c)
            {
                Console.WriteLine(+b + " eh o maior");
            }
            else
                Console.WriteLine(+c + " eh o maior");
        }
    }
}
