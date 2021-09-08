using System;

namespace Actividad_1_Problema_1
{
    class Actividad_1_Problema_1
    {
        static void Main(string[] args)
        {

            //CREADO por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            Console.WriteLine("Problema 1");
            Console.WriteLine("Encontrar el valor absoluto de un numero");
            Console.WriteLine("-------------------------------------------------");

            float Numero, Numero2 = 0;

            Console.WriteLine("Ingresar un numero para calcular su valor absoluto");
            Numero = float.Parse(System.Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");

            if (Numero >= Numero2)
            {
                Console.WriteLine("El valor absoluto es: {0}", Numero);
                Console.WriteLine(" ");
            }
            else
            {
                Numero = -Numero;
                Console.WriteLine("El valor absoluto es: {0}", Numero);
                Console.WriteLine(" ");
            }


        }
    }
}
