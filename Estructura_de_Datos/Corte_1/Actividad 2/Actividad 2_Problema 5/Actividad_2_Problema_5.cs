using System;

namespace Actividad_2_Problema_5
{
    class Actividad_2_Problema_5
    {
        static void Main(string[] args)
        {
            //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
            //Creado por: Juan Diego Rodriguez Riaño
            //Actividad semana2
            //Turno: Diurno
            //Codigo: 239-2A DIA

            // Problema 5: la diferencia de fecha,año, meses y dias.
            int fecha_actual, fecha_ingresada, meses, años, dias;
            string salida;
            Console.WriteLine(" ");
            Console.WriteLine("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine(" ");
            Console.WriteLine("***Problema 5: La fecha actual comparacion ");
            Console.WriteLine(" ");
            fecha_actual = 2021;

            do
            {

                Console.WriteLine("Escriba un año que no supere el actual: ");
                fecha_ingresada = int.Parse(System.Console.ReadLine());

                if (fecha_ingresada >= 2021)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("No es posible realizar el calculo en una fecha igual o superior a la actual");
                    Console.WriteLine(" ");
                }

                if (fecha_ingresada <= 2021)
                {
                    años = fecha_actual - fecha_ingresada;
                    meses = (años * 12);
                    dias = (meses * 30);
                    Console.WriteLine(" ");
                    Console.WriteLine("La diferencia de años entre {0} y {1} es de: {2} ", fecha_actual, fecha_ingresada, años);
                    Console.WriteLine(" ");
                    Console.WriteLine("La diferencia de meses entre {0} y {1} es de: {2} ", fecha_actual, fecha_ingresada, meses);
                    Console.WriteLine(" ");
                    Console.WriteLine("La diferencia de dias entre {0} y {1} es de: {2} ", fecha_actual, fecha_ingresada, dias);
                    Console.WriteLine(" ");





                }


                Console.WriteLine("¿Quiere salir? (S/N)");
                salida = Console.ReadLine();
                Console.WriteLine(" ");

            } while (salida != "s" && salida != "S");



        }
    }
}
