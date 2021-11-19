using System;

namespace URI1047_B{
    class Program
    {
        static void Main(string[] args)
        {
            string[] value = Console.ReadLine().Split(' ');
            int horasEntrada = int.Parse(value[0]);
            int minutosEntrada = int.Parse(value[1]);
            int horaSaida = int.Parse(value[2]);
            int minutosSaida = int.Parse(value[3]);
            TimeSpan t1 = new TimeSpan(horasEntrada, minutosEntrada, 0);
            TimeSpan t2 = new TimeSpan(horaSaida, minutosSaida, 0);
            TimeSpan horaDia = new TimeSpan(24, 0, 0);
            if (horasEntrada >= horaSaida)
            {
                horaDia = horaDia.Add(t2);
                horaDia = horaDia.Subtract(t1);
            }
            else
            {
                horaDia = t2.Subtract(t1);
            }
            if (t1 == t2)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horaDia.Hours, horaDia.Minutes);
            }
        }
    }
}
