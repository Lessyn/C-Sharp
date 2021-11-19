using System;

namespace URI1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(valor[0]);
            int horaFim = int.Parse(valor[1]);
            int duracao;


            if (horaInicio < horaFim)
            {
                duracao = horaFim - horaInicio;
            }
            else
            {
                duracao = 24 - horaInicio + horaFim;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
