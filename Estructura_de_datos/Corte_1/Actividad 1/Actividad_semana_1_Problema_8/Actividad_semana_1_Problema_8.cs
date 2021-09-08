using System;

namespace Actividad_semana_1_Problema_8
{
    class Actividad_semana_1_Problema_8
    {
        static void Main(string[] args)
        {
            //Presentado por Jonathan David Guerrero Gomez
            //Grupo 239-2A DIA
            //Turno Diurno

            String entrada = "";
            char Letra;

            Console.WriteLine("Problema No.8");
            Console.WriteLine("Es una vocal, minuscula, mayuscula o un simbolo del alfabeto");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Ingrese el Digito");
            entrada = Console.ReadLine();
            Letra = Convert.ToChar(entrada);

            if (Letra == 'a' || Letra == 'e' || Letra == 'i' || Letra == 'o' || Letra == 'u')
            {
                Console.WriteLine("- {0} es una vocal.", Letra);
                Console.WriteLine("- {0} es una letra del alfabeto.", Letra);
                Console.WriteLine("- {0} es una letra minuscula.", Letra);
            }
            else if (Letra == 'A' || Letra == 'E' || Letra == 'I' || Letra == 'O' || Letra == 'U')
            {
                Console.WriteLine("- {0} es una vocal.", Letra);
                Console.WriteLine("- {0} es una letra del alfabeto.", Letra);
                Console.WriteLine("- {0} es una letra mayuscula.", Letra);
            }
            else if (Letra == 'b' || Letra == 'c' || Letra == 'd' || Letra == 'f' || Letra == 'g' || Letra == 'h' || Letra == 'j' || Letra == 'k' || Letra == 'l' || Letra == 'm' || Letra == 'n' || Letra == 'ñ' || Letra == 'p' || Letra == 'q' || Letra == 'r' || Letra == 's' || Letra == 't' || Letra == 'v' || Letra == 'w' || Letra == 'x' || Letra == 'y' || Letra == 'z')
            {
                Console.WriteLine("- {0} es una letra del alfabeto.", Letra);
                Console.WriteLine("- {0} es una letra minuscula.", Letra);
            }
            else if (Letra != 'b' || Letra != 'c' || Letra != 'd' || Letra != 'f' || Letra != 'g' || Letra != 'h' || Letra != 'j' || Letra != 'k' || Letra != 'l' || Letra != 'm' || Letra != 'n' || Letra != 'ñ' || Letra != 'p' || Letra != 'q' || Letra != 'r' || Letra != 's' || Letra != 't' || Letra != 'v' || Letra != 'w' || Letra != 'x' || Letra != 'y' || Letra != 'z')
            {
                Console.WriteLine("- {0} es una letra del alfabeto.", Letra);
                Console.WriteLine("- {0} es una letra mayuscula.", Letra);
            }
        }
    }
}
