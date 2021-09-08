using System;

namespace Actividad_semana_1_Problema_6
{
    class Actividad_semana_1_Problema_6
    {
        static void Main(string[] args)
        {
            //Presentado por Jonathan David Guerrero Gomez
            //Grupo 239-2A DIA
            //Turno Diurno

            String entrada = "";
            int Segundos = 0, Dia = 0, Minutos = 0, Hora = 0;

            Console.WriteLine("Problema No.6");
            Console.WriteLine("El tiempo");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Ingrese una cantidad de segundos");
            entrada = Console.ReadLine();
            Segundos = Convert.ToInt32(entrada);
            Console.WriteLine("--------------------------------------");

            Dia = Segundos/(24 * 60 * 60);
            Segundos = Segundos % (24 * 60 * 60);
            Hora = Segundos / (60 * 60);
            Segundos = Segundos % (60 * 60);
            Minutos = Segundos / 60;
            Segundos = Segundos / 60;

            Console.WriteLine("Es igual a:\n{0} Dias, {1} Horas, {2} Minutos y {3} Segundos.", Dia,Hora,Minutos,Segundos);
        }
    }
}
