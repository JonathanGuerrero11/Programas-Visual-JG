using System;

namespace Actividad_1_Problema_9
{
    class Actividad_1_Problema_9
    {
        static void Main(string[] args)
        {
            //CREADO por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            Console.WriteLine("Problema 1");
            Console.WriteLine("Encontrar el valor absoluto de un numero");
            Console.WriteLine("-------------------------------------------------");

            double Edad=0, Añosperrunos=0;
            String Nombre = "";

            Console.WriteLine("Ingrese la edad humana: ");
            Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Ingrese el nombre de sus mascota");
            Nombre = Console.ReadLine();

            if (Edad <= 2)
            {
                Añosperrunos = Edad * 10.5;
                Console.WriteLine("La edad es {0} y en años perrunos {1} tiene {2}", Edad,Nombre, Añosperrunos);
            }
            else
            {
                Añosperrunos = 21 + (Edad - 2) * 4;

                Console.WriteLine("La edad es {0} y en años perrunos {1} tiene aproximadamente {2}", Edad,Nombre, Añosperrunos);
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Fin del programa :D");
        }
    }
}
