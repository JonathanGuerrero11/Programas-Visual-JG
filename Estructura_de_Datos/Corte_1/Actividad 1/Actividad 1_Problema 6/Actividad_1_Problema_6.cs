using System;

namespace Actividad_1_Problema_6
{
    class Actividad_1_Problema_6
    {
        static void Main(string[] args)
        {
            //CREADO por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            Console.WriteLine("Problema 6");
            Console.WriteLine("Programa que calcula cuanto tiempo es");
            Console.WriteLine("-------------------------------------------------");

            int Fecha=0,Dia=0, Minutos=0, Horas=0, Segundos=0, Minutos2=0;

                Console.WriteLine("Ingrese el numero del que quiere conocer el periodo de tiempo (en segundos): ");
                Fecha = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------");

            if(Fecha==0)
            {
                Console.WriteLine("El 0 no es un valor valido");
            }


            if (Fecha >= 1)
            {
                Minutos = Fecha / 60;
                Segundos = Fecha % 60;
                Horas = Minutos / 60;
                Minutos2 = Minutos % 60;
                Dia = Horas / 24;

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("La cantidad de segundos es: {0}", Segundos);
                Console.WriteLine("La cantidad de horas es {0} ", Horas);
                Console.WriteLine("La cantidad de minutos es: {0}", Minutos2);
                Console.WriteLine("La cantidad de dias es: {0}", Dia);
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Fin del programa :D");
        }
    }
}
