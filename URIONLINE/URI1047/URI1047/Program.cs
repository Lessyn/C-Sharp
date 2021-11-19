using System;

namespace URI1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] horario = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(horario[0]);
            int minutoInicial = int.Parse(horario[1]);
            int horaFinal = int.Parse(horario[2]);
            int minutoFinal = int.Parse(horario[3]);

            int tempoMinutoFinal = horaFinal * 60 + minutoFinal;
            int tempoMinutoInical = horaInicio * 60 + minutoInicial;
            int minutosTotais = (24 * 60 - tempoMinutoInical) + tempoMinutoFinal;

            int horas = minutosTotais / 60;
            int minutos = minutosTotais % 60;

            if (horas >= 24 && minutos >= 1)
            {
                horas = horas % 24;
            }

            Console.WriteLine("O JOGO DUROU " + horas + " HORA(S) E " + minutos + " MINUTO(S)");
        }
    }
}
