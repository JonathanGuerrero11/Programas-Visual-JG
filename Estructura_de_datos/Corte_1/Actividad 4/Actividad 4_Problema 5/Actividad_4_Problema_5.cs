using System;

namespace Actividad_4_Problema_5
{
    class Actividad_4_Problema_5
    {
        static void Main(string[] args)
        {
            int num = 0, cont = 0, cont2 = 0, cont3;

            string[] numeros = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "Ñ", "N", "O", "P", "R", "S", "T", "U", "V", "X", "Y", "Z" };
            int[] numeros1 = new int[30];
            do
            {
                Console.WriteLine("dijire un numero:(salir(-1))");
                num = int.Parse(Console.ReadLine());
                numeros1[cont] = num;
                cont = cont + 1;
                cont2 = cont2 + 1;
            } while (num > -1);
            cont2 = cont2 - 1;

            for (cont3 = 0; cont3 < cont2; cont3++)
            {
                Console.WriteLine("la letra {0} es:{1}", cont3, numeros[numeros1[cont3]]);
                Console.WriteLine("");


            }
            Console.WriteLine("Cadena restante:");
            for (cont3 = 0; cont3 < cont2; cont3++)
            {

                Console.Write(numeros[numeros1[cont3]]);



            }


            if (cont2 > 26)
            {
                Console.WriteLine("ERROR coloque menos de 24");


            }


            //Grupo:  Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño  
            //Creado por Juan Esteban Jimenez Cuestas
            //Grupo 239-2A DIA
            //Turno Diurno

        }
    }
}
