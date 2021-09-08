using System;

namespace Actividad_1_Problema_7
{
    class Actividad_1_Problema_7
    {
        static void Main(string[] args)
        {
            //CREADO por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            Console.WriteLine("Problema 7");
            Console.WriteLine("El programa es un informe de las ventas");
            Console.WriteLine("-------------------------------------------------");

            int A = 0,B=0,C=0,Total=0;
            string Repetir;

            do
            {

                Console.WriteLine("Ingrese las ventas del producto A: ");
                A = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Ingrese las ventas del producto B: ");
                B = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Ingrese las ventas del producto C: ");
                C = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------");

                Total = A + B + C;

                if (A > B && A > C)
                {
                    Console.WriteLine("El producto A es quien tiene mas ventas {0}",A);
                    Console.WriteLine("-------------------------------------------------");

                }
                else if (B > A && B > C)
                {
                    Console.WriteLine("El producto B es quien tiene mas ventas {0}", B);
                    Console.WriteLine("-------------------------------------------------");

                }
                else if (C > B && C > A)
                {
                    Console.WriteLine("El producto C es quien tiene mas ventas {0}", C);
                    Console.WriteLine("-------------------------------------------------");

                }

                if (B < A && B < C)
                {
                    Console.WriteLine("El producto B es quien tiene menos ventas {0}", B);
                    Console.WriteLine("-------------------------------------------------");

                }
                else if (A < B && A < C)
                {
                    Console.WriteLine("El producto A es quien tiene menos ventas {0}", A);
                    Console.WriteLine("-------------------------------------------------");

                }
                else if (C < A && C < B)
                {
                    Console.WriteLine("El producto C es quien tiene menos ventas {0}", C);
                    Console.WriteLine("-------------------------------------------------");

                }


                if (A >= 200 && B >= 200 && C >= 200)
                {
                    Console.WriteLine("Ningun producto tiene ventas inferiores a las 200.");
                    Console.WriteLine("-------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Hay productos con ventas inferiores a 200.");
                    Console.WriteLine("-------------------------------------------------");
                }



                if (A >= 400 || B >= 400 || C >= 400)
                {
                    Console.WriteLine("Uno de los productos tiene ventas superiores a las 400.");
                    Console.WriteLine("-------------------------------------------------");
                }


                if (Total / 3 > 500)
                {
                    Console.WriteLine("La media de ventas de los productos es superior a 500");
                    Console.WriteLine("-------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La media de ventas de los productos es menor a 500");
                    Console.WriteLine("-------------------------------------------------");
                }



                if (Total >= 500 && Total <= 1000)
                {
                    Console.WriteLine("Las ventas totales de los producto esta entre 500 y 1000");
                    Console.WriteLine("-------------------------------------------------");
                }



                Console.WriteLine("¿Desea salir? (S/N)");
                Repetir = Console.ReadLine();

            } while (Repetir != "S" && Repetir != "s");
        }
    }
}
