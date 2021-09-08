using System;

namespace Actividad_semana_1_Problema_5
{
    class Actividad_semana_1_Problema_5
    {
        static void Main(string[] args)
        {
            //Presentado por Jonathan David Guerrero Gomez
            //Grupo 239-2A DIA
            //Turno Diurno

            String entrada = "";
            Double Valor = 0,Valorf=0;

            Console.WriteLine("Problema No.5");
            Console.WriteLine("Raiz");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Ingrese un valor para sacarle la raiz");
            entrada = Console.ReadLine();
            Valor = Convert.ToDouble(entrada);

            if (Valor > 0)
            {
                Valorf = Math.Sqrt(Valor);
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("La raiz de {0} es {1}", Valor,Valorf);
            }
            else if (Valor == 0) {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("El 0 es neutro no es valido");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("El numero es negativo no es valido");
            }
        }
    }
}
