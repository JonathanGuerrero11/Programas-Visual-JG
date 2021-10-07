using System;
using System.Collections;

namespace Actividad_6_Problema_1
{
    class Actividad_6_Problema_1
    {
        static void Main(string[] args)
        {
            int num1, num2;
            ArrayList nument = new ArrayList();
            Console.WriteLine("ingrese numero entero");
            do
            {


                num2 = int.Parse(Console.ReadLine());
                nument.Add(num2);

            } while (num2 != 0);
            Console.WriteLine("el numero que coloco es:");
            foreach (int esnum in nument)
            {

                Console.Write(esnum);
                Console.WriteLine("");
            }
        }
    }
}
