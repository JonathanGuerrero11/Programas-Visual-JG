using System;

namespace Actividad_semana_1_Problema_10
{
    class Actividad_semana_1_Problema_10
    {
        static void Main(string[] args)
        {
            //Presentado por Jonathan David Guerrero Gomez
            //Grupo 239-2A DIA
            //Turno Diurno

            String entrada = "", Usu="", Contraseña="";
            int Cont = 0;

            Console.WriteLine("Problema No.10");
            Console.WriteLine("Simulacion de contraseña");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("            Inicio de Sesion");
            Console.WriteLine("Ingrese su nombre");
            entrada = Console.ReadLine();
            Usu = Convert.ToString(entrada);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Hola, bienvenido {0} :D",Usu);

            //La contraseña es "iloveyou123"

            do
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Ingrese la contraseña");
                entrada = Console.ReadLine();
                Contraseña = Convert.ToString(entrada);

                if (Contraseña == ("iloveyou123"))
                {
                    Cont = Cont + 1;
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Inicio de sesion correcto :D");                  
                }
                else if (Contraseña != ("iloveyou123"))
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("La contraseña esta mal :(");
                }
            } while (Cont != 1);
        }
    }
}
