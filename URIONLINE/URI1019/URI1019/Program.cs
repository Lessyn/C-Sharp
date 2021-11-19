using System;
using System.Timers;

namespace URI1019
{
    class Program
    {
        static void Main(string[] args)
        {            
            
            int Tsegundos = int.Parse(Console.ReadLine());

            int horas = Tsegundos / 3600;
            Tsegundos = Tsegundos % 3600;
            int minutos = Tsegundos / 60;
            Tsegundos = Tsegundos % 60;

            int segundos = Tsegundos;                   

            Console.WriteLine( "{0}:{1}:{2}", horas, minutos, segundos);

        }
    }
}
