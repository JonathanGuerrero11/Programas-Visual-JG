using System;

namespace Actividad_1_Problema_10
{
    class Actividad_1_Problema_10
    {
        static void Main(string[] args)
        {
            //CREADO por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            Console.WriteLine("Problema 10");
            Console.WriteLine("Inicio de sesion");
            Console.WriteLine("-------------------------------------------------");

            string Contraseña;
            int Fin = 0;

            Console.WriteLine("La contraseña es iloveyou123. ");
            Console.WriteLine("-------------------------------------------------");

            while (Fin == 0)
            {
                Console.WriteLine("Ingrese la contraseña: ");
                Contraseña = Console.ReadLine();
                Console.WriteLine("-------------------------------------------------");



                if (Contraseña == "iloveyou123")
                {
                    Fin = 1;

                }
                
                if (Contraseña != "iloveyou123")
                {
                    Console.WriteLine("La contraseña es incorrecta, vuelva a intentar ");
                    Console.WriteLine("-------------------------------------------------");
                }

            }

            Console.WriteLine("Exitoso inicio de sesion, Bienvenido :D");

        }
    }
}
