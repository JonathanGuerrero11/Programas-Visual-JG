using System;

namespace Actividad_semana_1_Problema_7
{
    class Actividad_semana_1_Problema_7
    {
        static void Main(string[] args)
        {
            //Presentado por Jonathan David Guerrero Gomez
            //Grupo 239-2A DIA
            //Turno Diurno

            String entrada = "";
            Double A = 0, B = 0, C = 0, Total=0,Promedio=0; 

            Console.WriteLine("Problema No.7");
            Console.WriteLine("Productos A, B, C y las afirmaciones");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Ingrese las ventas para el producto A");
            entrada = Console.ReadLine();
            A = Convert.ToDouble(entrada);

            Console.WriteLine("Ingrese las ventas para el producto B");
            entrada = Console.ReadLine();
            B = Convert.ToDouble(entrada);

            Console.WriteLine("Ingrese las ventas para el producto C");
            entrada = Console.ReadLine();
            C = Convert.ToDouble(entrada);
            Console.WriteLine("-------------------------------------------");
            if ((A > B) && (A > C))
            {
                Console.WriteLine("- Las ventas del producto A son las mas elevadas, sus ventas fueron de ${0}",A);
            }
            else if ((B > A) && (B > C))
            {
                Console.WriteLine("- Las ventas del producto B son las mas elevadas, sus ventas fueron de ${0}", B);
            }
            else if ((C > B) && (C > A))
            {
                Console.WriteLine("- Las ventas del producto C son las mas elevadas, sus ventas fueron de ${0}", C);
            }


            if ((A<200) && (B<200) && (C < 200))
            {
                Console.WriteLine("- Ninguno de los productos tuvo unas ventas inferiores a $200");
            }
            else
            {
                if (A < 200)
                {
                    Console.WriteLine("- El producto A tuvo ventas inferiores a $200, sus ventas fueron ${0}",A);
                }
                else
                {
                    if (B < 200)
                    {
                        Console.WriteLine("- El producto B tuvo ventas inferiores a $200, sus ventas fueron ${0}", B);
                    }
                    else
                    {
                        if (C < 200)
                        {
                            Console.WriteLine("- El producto C tuvo ventas inferiores a $200, sus ventas fueron ${0}", C);
                        }
                    }
                }
            }


            if(A > 400)
            {
                Console.WriteLine("- Las ventas del producto A son mayores a $400, fueron ${0}",A);
            }
            else if(B > 400)
            {
                Console.WriteLine("- Las ventas del producto B son mayores a $400, fueron ${0}", B);
            }
            else if (C > 400)
            {
                Console.WriteLine("- Las ventas del producto C son mayores a $400, fueron ${0}", C);
            }

            Promedio = (A + B + C) / 3;
            if (Promedio>500)
            {
                Console.WriteLine("- La media de ventas fue superior a $500 fueron de {0}",Promedio);
            }
            else
            {
                Console.WriteLine("- La media de ventas no fueron superiores a $500 fueron de {0}", Promedio);
            }


            if ((B < A) && (B < C))
            {
                Console.WriteLine("- El producto menos vendido fue el B sus ventas fueron de ${0}",B);
            }
            else if ((A < B) && (A < C))
            {
                Console.WriteLine("- El producto menos vendido fue el A sus ventas fueron de ${0}", A);
            }
            else if ((C < A) && (C < B))
            {
                Console.WriteLine("- El producto menos vendido fue el C sus ventas fueron de ${0}", C);
            }


            Total = (A + B + C);

            if ((Total >= 500) && (Total <= 1000))
            {
                Console.WriteLine("- El total de ventas esta entre $500 y $1000 fueron ${0}", Total);
            }
            else
            {
                if (Total < 500)
                {
                    Console.WriteLine("- El total de ventas fueron menores de $500 y $1000 fueron ${0}", Total);
                }
                else
                {
                    Console.WriteLine("- El total de ventas fueron mayores de $500 y $1000 fueron ${0}", Total);
                }
            }
            Console.WriteLine("-------------------------------------------");
        }
    }
}
