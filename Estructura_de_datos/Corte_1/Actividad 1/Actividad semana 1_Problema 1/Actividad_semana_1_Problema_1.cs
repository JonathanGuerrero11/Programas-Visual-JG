using System;

namespace Actividad_semana_1_Problema_1
{
    class Actividad_semana_1_Problema_1
    {
        static void Main(string[] args)
        {
            //Presentado por Jonathan David Guerrero Gomez
            //Grupo 239-2A DIA
            //Turno Diurno

            String entrada = "";
            double Num = 0, Numf = 0;

            Console.WriteLine("Problema No.1");
            Console.WriteLine("Valor Absoluto de un numero");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ingrese un numero el cual quiera saber su valor adsoluto");
            entrada = Console.ReadLine();
            Num = Convert.ToDouble(entrada);

            Console.WriteLine("");

            if (Num > 0)
            {
                Numf = Num;
            }
            else {
                if (Num < 0)
                {
                    Numf = -1*(Num);
                }
                else
                {
                    Numf = 0;
                }
            }
                Console.WriteLine("El valor adsoluto de |{0}| es {1}.", Num, Numf);
        }
    }
}
