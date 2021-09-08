using System;

namespace Actividad_1_Problema_4
{
    class Actividad_1_Problema_4
    {
        static void Main(string[] args)
        {
            //CREADO por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            Console.WriteLine("Problema 4");
            Console.WriteLine("La conjetura de Collatz");
            Console.WriteLine("-------------------------------------------------");

            double Numero, Valor = 1;

            while (Valor == 1)
            {

                Console.WriteLine("Para salir digite 0");
                Console.WriteLine("Ingrese un numero (Diferente a 1)");
                Numero = double.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------");

                if (Numero == 1)
                {
                    Console.WriteLine("Este numero no hace parte de la secuencia");
                    Console.WriteLine("-------------------------------------------------");
                }

                while (Numero > 1)
                {
                    if (Numero % 2 == 0)
                    {
                        Console.WriteLine("La secuencia de este numero par es ");
                        Numero = Numero / 2;
                        Console.WriteLine("{0}", Numero);
                        Console.WriteLine("-------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("La secuencia de este numero impar es ");
                        Numero = (Numero * 3) + 1;
                        Console.WriteLine("{0}", Numero);
                        Console.WriteLine("-------------------------------------------------");

                    }

                }


                if (Numero == 0)
                {
                    Valor = 0;
                }

            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Fin del programa :D");
        }
    }
}
