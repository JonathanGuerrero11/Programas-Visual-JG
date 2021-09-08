using System;

namespace Actividad_semana_1_Problema_4
{
    class Actividad_semana_1_Problema_4
    {
        static void Main(string[] args)
        {
            //Presentado por Jonathan David Guerrero Gomez
            //Grupo 239-2A DIA
            //Turno Diurno

            String entrada = "";
            int Valor1 = 0, Valor2 = 0 ;


            Console.WriteLine("Problema No.4");
            Console.WriteLine("Conjetura de Collatz");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Digite un valor, con 1 termina el proceso");
            entrada = Console.ReadLine();
            Valor1 = Convert.ToInt32(entrada);
            Valor2 = Valor1;

            while (Valor2 > 1)
            { 

                if (Valor2 % 2 == 0)
                {
                    Valor2 = Valor2 / 2;
                    Console.WriteLine(Valor2);
                }
                else
                {
                    Valor2 = (Valor2 * 3) + 1;
                    Console.WriteLine(Valor2);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Esta fue la conjetura de collatz consecutiva del {0}.",Valor1);
        }
    }
}
