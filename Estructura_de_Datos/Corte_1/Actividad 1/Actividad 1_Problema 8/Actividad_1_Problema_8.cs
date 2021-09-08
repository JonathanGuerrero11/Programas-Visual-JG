using System;

namespace Actividad_1_Problema_8
{
    class Actividad_1_Problema_8
    {
        static void Main(string[] args)
        {
            //CREADO por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            Console.WriteLine("Problema 8");
            Console.WriteLine("vocal,letra minuscula y alfabeto");
            Console.WriteLine("-------------------------------------------------");

            char Letra;
            string Repetir = "";

            do
            {

                Console.WriteLine("Escriba una letra: ");
                Letra = char.Parse(Console.ReadLine());

                if (char.IsUpper(Letra))
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("El valor ingresado esta en el alfabeto");
                    Console.WriteLine("La letra {0} es mayuscula. ", Letra);

                    switch (Letra)
                    {
                        case 'A':
                            Console.WriteLine("La letra {0} es una vocal", Letra);
                            break;
                        case 'E':
                            Console.WriteLine("La letra {0} es una vocal", Letra);
                            break;
                        case 'I':
                            Console.WriteLine("La letra {0} es una vocal", Letra);
                            break;
                        case 'O':
                            Console.WriteLine("La letra {0} es una vocal", Letra);
                            break;
                        case 'U':
                            Console.WriteLine("La letra {0} es una vocal", Letra);
                            break;

                    }

                }
                else if (char.IsLower(Letra))
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("El valor ingresado esta en el alfabeto");
                    Console.WriteLine("La letra {0} es minuscula. ", Letra);

                    switch (Letra)
                    {
                        case 'a':
                            Console.WriteLine("La letra {0} es una vocal", Letra);
                            break;
                        case 'e':
                            Console.WriteLine("La letra {0} es una vocal", Letra);
                            break;
                        case 'i':
                            Console.WriteLine("La letra {0} es una vocal", Letra);
                            break;
                        case 'o':
                            Console.WriteLine("La letra {0} es una vocal", Letra);
                            break;
                        case 'u':
                            Console.WriteLine("La letra {0} es una vocal", Letra);
                            break;
                    }



                }
                else
                {
                    Console.WriteLine("El caracter ingresado {0} no esta en el alfabeto ", Letra);
                }

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("¿Desea salir del sistema (s/n)?");
                Repetir = Console.ReadLine();
            } while (Repetir != "s" && Repetir != "S");
        }
    }
}
