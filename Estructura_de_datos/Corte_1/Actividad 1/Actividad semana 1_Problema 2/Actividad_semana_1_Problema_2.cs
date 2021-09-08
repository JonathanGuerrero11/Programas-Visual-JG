using System;

namespace Actividad_semana_1_Problema_2
{
    class Actividad_semana_1_Problema_2
    {
        static void Main(string[] args)
        {
            //Presentado por Jonathan David Guerrero Gomez
            //Grupo 239-2A DIA
            //Turno Diurno

            String entrada = "", Nom = "",Peli1="", Peli2 = "", Peli3 = "";
            float Precio1 = 0f, Precio2 = 0f, Precio3 = 0f,Preciof=0f;

            Console.WriteLine("Problema No.2");
            Console.WriteLine("Precios de las peliculas");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");


            Console.WriteLine("Por favor ingrese su nombre");
            entrada = Console.ReadLine();
            Nom = Convert.ToString(entrada);

            Console.WriteLine("");
            Console.WriteLine("Bienvenido Sr. {0}",Nom);
            Console.WriteLine("Tenemos la promocion de llevar tres peliculas solo paga las dos mas baratas");

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("¿Que pelicula va a escoger?");
            entrada = Console.ReadLine();
            Peli1 = Convert.ToString(entrada);
            Console.WriteLine("Ingrese el precio de la pelicula");
            entrada = Console.ReadLine();
            Precio1 = Convert.ToSingle(entrada);
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("¿Cual otra pelicula va a escoger?");
            entrada = Console.ReadLine();
            Peli2 = Convert.ToString(entrada);
            Console.WriteLine("Ingrese el precio de la pelicula");
            entrada = Console.ReadLine();
            Precio2 = Convert.ToSingle(entrada);
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("¿Cual otra pelicula va a escoger?");
            entrada = Console.ReadLine();
            Peli3 = Convert.ToString(entrada);
            Console.WriteLine("Ingrese el precio de la pelicula");
            entrada = Console.ReadLine();
            Precio3 = Convert.ToSingle(entrada);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            if (Precio1 < Precio2)
            {
                if (Precio2 > Precio3)
                {
                    Preciof = Precio3 + Precio1;
                }
                else
                {
                    Preciof = Precio2 + Precio1;
                }
            }
            else
            {
                if (Precio1 > Precio3)
                {
                    Preciof = Precio3 + Precio2;
                }
                else
                {
                    Preciof = Precio1 + Precio2;
                }
            }

            Console.WriteLine("Peliculas      Precio\n- {0}   |  ${1} \n- {2}   |  ${3} \n- {4}   |  ${5} ", Peli1,Precio1,Peli2,Precio2,Peli3,Precio3);
            Console.WriteLine("");
            Console.WriteLine("TOTAL A PAGAR {0}",Preciof);
        }
    }
}
