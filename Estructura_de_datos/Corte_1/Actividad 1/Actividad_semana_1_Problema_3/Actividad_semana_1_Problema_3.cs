using System;

namespace Actividad_semana_1_Problema_3
{
    class Actividad_semana_1_Problema_3
    {
        static void Main(string[] args)
        {
            //Presentado por Jonathan David Guerrero Gomez
            //Grupo 239-2A DIA
            //Turno Diurno

            String entrada = "", Estudiante = "";
            int Cont = 0;
            float Nota = 0f, Notam = 0f,Notap=50f,Promedio=0f,Nt=0f;

            Console.WriteLine("Problema No.3");
            Console.WriteLine("Promedio notas y cual es mejor y la peor nota");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Ingrese el nombre del estudiante");
            entrada = Console.ReadLine();
            Estudiante = Convert.ToString(entrada);
            Console.WriteLine("");

            do
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Ingrese sus notas: \n(Rango de 0 a 50)");
                entrada = Console.ReadLine();
                Nota = Convert.ToSingle(entrada);

                Nt = Nt + Nota;

                if (Nota > Notam)
                {
                    Notam = Nota;
                }


                if (Nota < Notap)
                {
                    Notap = Nota;
                }

                Cont = Cont + 1;

            } while (Cont != 4);

            Promedio = Nt / 4;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("El promedio de las notas de {0} en estructura de datos es {1}.", Estudiante, Promedio);
            Console.WriteLine("La mejor nota de {0} en estructura de datos fue {1}.", Estudiante, Notam);
            Console.WriteLine("La peor nota de {0} en estructura de datos fue {1}.", Estudiante, Notap);
        }
    }
}
