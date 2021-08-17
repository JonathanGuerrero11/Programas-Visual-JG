using System;

namespace Actividad_semana_1_Problema_9
{
    class Actividad_semana_1_Problema_9
    {
        static void Main(string[] args)
        {
            //Presentado por Jonathan David Guerrero Gomez
            //Grupo 239-2A DIA
            //Turno Diurno

            String entrada = "", Nom="";
            double Edadp = 0, Edadp2=0;

            Console.WriteLine("Problema No.9");
            Console.WriteLine("Este programa calcula la edad de un perro en años humanos");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("¿Como se llama el perro?");
            entrada= Console.ReadLine();
            Nom = Convert.ToString(entrada);

            Console.WriteLine("Digite la edad de su perro");
            entrada = Console.ReadLine();
            Edadp=Convert.ToDouble(entrada);

            if (Edadp <= 2)
            {
                Edadp2 = Edadp;
                Edadp = Edadp * 10.5;
            }
            else
            {
                Edadp2 = Edadp;
                Edadp = 21+(Edadp -2) * 4;        
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Tu perro {0} tiene {1} años, en años humanos esos son {2} años.",Nom, Edadp2, Edadp);
        }
    }
}
