using System;

namespace Programa_de_prueba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Valor1 = 8;
            int valor2 = 11;
            int Valor3 = 4;
            int Resultado = 0;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Tenemos los siguentes numeros {0}, {1}, {2}", Valor1, valor2, Valor3);
            Console.WriteLine("");
            Resultado = (Valor1 + valor2) * Valor3;
            Console.WriteLine("Tenemos la siguiente operacion ({0} + {1}) * {2} eso da como resultado = {3}", Valor1, valor2, Valor3, Resultado);
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Fin. :D");
        }
    }
}
