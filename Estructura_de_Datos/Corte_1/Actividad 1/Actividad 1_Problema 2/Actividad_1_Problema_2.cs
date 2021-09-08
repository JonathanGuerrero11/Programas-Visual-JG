using System;

namespace Actividad_1_Problema_2
{
    class Actividad_1_Problema_2
    {
        static void Main(string[] args)
        {
            //CREADO por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            Console.WriteLine("Problema 2");
            Console.WriteLine("Calcular el valor total de las peliculas");
            Console.WriteLine("-------------------------------------------------");

            Double Pelicula1, Pelicula2, Pelicula3, Total;

            Console.WriteLine("Ingrese el precio de la primera pelicula");
            Pelicula1 = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Ingrese el precio de la segunda pelicula");
            Pelicula2 = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Ingrese el precio de la tercera pelicula");
            Pelicula3 = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");

            if (Pelicula1 > Pelicula2 && Pelicula1 > Pelicula3)
            {
                Total = Pelicula2 + Pelicula3;
                Console.WriteLine("El total a pagar por las 3 peliculas es {0} ", Total);
            }
            else if (Pelicula2 > Pelicula1 && Pelicula2 > Pelicula3)
            {
                Total = Pelicula3 + Pelicula1;
                Console.WriteLine("El total a pagar por las 3 peliculas es {0} ", Total);

            }
            else
            {
                Total = Pelicula1 + Pelicula2;
                Console.WriteLine("El total a pagar por las 3 peliculas es {0} ", Total);

            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Fin del programa :D");

        }
    }
}
