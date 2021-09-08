using System;

namespace Actividad_1_Problema_3
{
    class Actividad_1_Problema_3
    {
        static void Main(string[] args)
        {
            //CREADO por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            Console.WriteLine("Problema 3");
            Console.WriteLine("Calcular las notas de los estudiantes");
            Console.WriteLine("-------------------------------------------------");

            double Calificacion, Calificacion2, Calificacion3, Calificacion4, Promedio;

            Console.WriteLine("Ingrese la calificacion del estudiante 1");
            Calificacion = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Ingrese la calificacion del estudiante 2");
            Calificacion2 = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Ingrese la calificacion del estudiante 3");
            Calificacion3 = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Ingrese la calificacion del estudiante 4");
            Calificacion4 = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");


            if (Calificacion > Calificacion2 && Calificacion > Calificacion3 && Calificacion > Calificacion4)
            {
                Console.WriteLine("La calificacion mas alta fue del estudiante 1 fue de {0}",Calificacion);
            }
            else if (Calificacion2 > Calificacion && Calificacion2 > Calificacion3 && Calificacion2 > Calificacion4)
            {
                Console.WriteLine("La calificacion mas alta fue del estudiante 2 fue de {0}", Calificacion2);
            }

            else if (Calificacion4 > Calificacion2 && Calificacion4 > Calificacion3 && Calificacion4 > Calificacion)
            {
                Console.WriteLine("La calificacion mas alta fue del estudiante 4 fue de {0}", Calificacion4);
            }
            else if(Calificacion3 > Calificacion && Calificacion3 > Calificacion2 && Calificacion3 > Calificacion4)
            {
                Console.WriteLine("La calificacion mas alta fue del estudiante 3 fue de {0}",Calificacion3);
            }


            if (Calificacion < Calificacion2 && Calificacion < Calificacion3 && Calificacion < Calificacion4)
            {
                Console.WriteLine("La calificacion mas baja fue del estudiante 1 fue de {0}", Calificacion);
            }
            else if(Calificacion2 < Calificacion && Calificacion2 < Calificacion3 && Calificacion2 < Calificacion4)
            {
                Console.WriteLine("La calificacion mas baja fue del estudiante 2 fue de {0}", Calificacion2);
            }

            else if(Calificacion4 < Calificacion2 && Calificacion4 < Calificacion3 && Calificacion4 < Calificacion)
            {
                Console.WriteLine("La calificacion mas baja fue del estudiante 4 fue de {0}", Calificacion4);
            }
            else if(Calificacion3 < Calificacion && Calificacion3 < Calificacion2 && Calificacion3 < Calificacion4)
            {
                Console.WriteLine("La calificacion mas baja fue del estudiante 3 fue de {0}", Calificacion3);
            }



            Promedio = (Calificacion + Calificacion2 + Calificacion3 + Calificacion4) / 4;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("El promedio fue de {0}", Promedio);
        }
    }
}
