using System;

namespace Actividad_1_Problema_5
{
    class Actividad_1_Problema_5
    {
        static void Main(string[] args)
        {
            //CREADO por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            Console.WriteLine("Problema 5");
            Console.WriteLine("Sacara la raiz cuadrada");
            Console.WriteLine("-------------------------------------------------");

            double Numero, Raiz;

            Console.WriteLine("Digite un numero");
            Numero = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");

            if (Numero >= 1)
            {

                Raiz = Math.Sqrt(Numero);
                Console.WriteLine("La raiz del {0} es {1} ", Numero, Raiz);
                Console.WriteLine("-------------------------------------------------");

            }


            if (Numero < 0)
            {
                Console.WriteLine("El numero no es positivo y no se le puede sacar un raiz cuadrada");
                Console.WriteLine("-------------------------------------------------");
            }

            if (Numero == 0)
            {
                Console.WriteLine("El numero es igual a 0 no se le puede sacar un raiz cuadrada");
                Console.WriteLine("-------------------------------------------------");
            }

            Console.WriteLine("Fin del programa :D");
        }
    }
}
