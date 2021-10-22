using System;
using System.Collections;
using System.Collections.Generic;

namespace Actividad_8_Problema_1
{
    class Actividad_8_Problema_1
    {
        static void Main(string[] args)
        {
            //CREADO POR Jonathan David Guerrero Gomez
            //Turno: Diurno
            //Codigo: 239-2A DIA

            string WhileLoop = "";
            String CadenaOri = "";
            string Frase3 = "";
            int Opcion = 0,Num=0;
            bool Encontrar = false;

            Console.WriteLine("Problema 1 --- CREADO POR Jonathan David Guerrero Gomez");
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Ingrese la palabra o frase a manipular");
            CadenaOri = Console.ReadLine();
            string CadenaOriginal = CadenaOri;

            do
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("                          Menu");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("1. Convertir un elemento a string (ToString)");
                Console.WriteLine("2. Fecha y hora actual (Date Time)");
                Console.WriteLine("3. Concatenar una frase con otra (Concat)");
                Console.WriteLine("4. Compara dos cadenas (Compare)");
                Console.WriteLine("5. Compara cadenas de texto (Equals)");
                Console.WriteLine("6. Saber si la letra se encuentra en la cadena (Contains)");
                Console.WriteLine("7. Conocer el sitio del digito (Substring)");
                Console.WriteLine("8. Comparar si la cadena termina con un elemento (EndsWith)");
                Console.WriteLine("9. Copia lo que se ingreso a una List y se pasa a la cadena original (CopyTo)");
                Console.WriteLine("10. Colocar otra palabra o letra en el sitio indicado (Insert)");
                Console.WriteLine("11. Permite saber cual donde esta ubicado la ultima letra (LastIndexOf)");
                Console.WriteLine("12. Inserta una letra en la parte izquierda de la cadena (PadLeft)");
                Console.WriteLine("13. Inserta una letra en la parte derecha de la cadena (PadRight)");
                Console.WriteLine("14. Permite eliminar caracteres desde ubicacion x hasta ubicacion x (Remove)");
                Console.WriteLine("15. Remplazar un caracter por otro (Replace)");
                Console.WriteLine("16. En cada renglon escribe una palabra de la cadena (Split)");
                Console.WriteLine("17. Pone toda la cadena en minusculas (ToLower)");
                Console.WriteLine("18. Pone toda la cadena en MAYUSCULAS (ToUppert)");
                Console.WriteLine("19. Elimina las apariciones iniciales y finales segun el caracter que inroduzca el usuario (Trim)");
                Console.WriteLine("20. Elimina el caracter inicial de la cadena (TrimStart)");
                Console.WriteLine("21. Elimina el caracter final de la cadena (TrimEnd)");
                Console.WriteLine("22. Agregar algo mas a la cadena (Append)");
                Console.WriteLine("23. Agrega mas texto a la cadena (AppendFormat)");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Que opcion escoge");
                Opcion = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Escogio la opcion {Opcion}");

                switch (Opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Escriba la nueva palabra a frase para que sea manipulada");
                            CadenaOri = Console.ReadLine();
                            CadenaOri = CadenaOri.ToString();

                            Console.WriteLine($"La nueva frase es {CadenaOri}");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine($"La fecha actual es {DateTime.Now.ToString("dddd, dd MMMM yyyy")} y son las {DateTime.Now.ToString("h: mm tt")}");
                            break;
                        }

                    case 3:
                        {
                            String[] Cadena2 = { CadenaOri };
                            string Nueva = "";

                            double[] keys = new double[CadenaOri.Length];
                            string[] letters = new string[CadenaOri.Length];

                            Random random = new Random();

                            foreach (string Palabra in Cadena2)
                            {
                                for (int ctr = 0; ctr < Palabra.Length; ctr++)
                                {
                                    keys[ctr] = random.NextDouble();
                                    letters[ctr] = Palabra[ctr].ToString();
                                }

                                Array.Sort(keys, letters, 0, CadenaOri.Length, Comparer.Default);

                                string[] scrambledWord = new string[CadenaOri.Length];

                                for (int i = 0; i < CadenaOri.Length; i++)
                                {
                                    scrambledWord[i] = String.Concat(letters[i]);
                                    Nueva = Nueva + scrambledWord[i];
                                }

                                Console.WriteLine($"{Palabra} --> {Nueva}");
                                CadenaOri = Nueva;
                                Console.WriteLine($"Cadena Actualizada = {CadenaOri}");
                            }
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Escriba la frase que quiere saber si esta igual que la original");
                            Frase3 = Console.ReadLine();

                            int Igual = CadenaOri.CompareTo(Frase3);

                            if (Igual == 0)
                            {
                                Console.WriteLine("La frase esta igual");
                            }
                            else
                            {
                                Console.WriteLine("La frase no esta igual");
                            }
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Ingrese la cadena para comparar la con la primera");
                            Frase3 = Console.ReadLine();

                            if (CadenaOri.Equals(Frase3))
                            {
                                Console.WriteLine("La frase es igual");
                            }
                            else
                            {
                                Console.WriteLine("La frase no es igual");
                            }
                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("Que letra o letras desea saber si se encuentran en la cadena");
                            string Encontrar1 = Console.ReadLine();
                            Encontrar = CadenaOri.Contains(Encontrar1);

                            if (Encontrar == true)
                            {
                                Console.WriteLine(Encontrar);
                                Console.WriteLine($"La {Encontrar1} se encuentra dentro de la cadena");
                            }
                            else
                            {
                                Console.WriteLine(Encontrar);
                                Console.WriteLine($"La {Encontrar1} NO se encuentra dentro de la cadena");
                            }
                            break;
                        }

                    case 7:
                        {
                            Console.WriteLine($"¿Cual digito quiere saber? del 0 hasta el {CadenaOri.Length - 1}");
                            Num = int.Parse(Console.ReadLine());

                            Console.WriteLine($"El digito N° {Num} de la cadena {CadenaOri} es {CadenaOri.Substring(Num, 1)}");
                            break;
                        }

                    case 8:
                        {
                            Console.WriteLine("Escriba la letra que cree que es la ultima");
                            string letra = Console.ReadLine();

                            CadenaOri.EndsWith(letra);
                            if (CadenaOri.EndsWith(letra))
                            {
                                Console.WriteLine($"{CadenaOri.EndsWith(letra)}, la ultima letra de la cadena es {letra}");
                            }
                            else
                            {
                                Console.WriteLine($"{CadenaOri.EndsWith(letra)}, la ultima letra no era la {letra}");
                            }
                            break;
                        }

                    case 9:
                        {
                            Console.WriteLine("Que desear ingresar para el List");
                            string Agregar2 = Console.ReadLine();

                            List<string> Al = new List<string>();
                            Al.Add(Agregar2);

                            String[] Cadenacopy=new string[1];
                            Al.CopyTo(Cadenacopy);
                            foreach(string Copy in Cadenacopy)
                            {
                                CadenaOri = CadenaOri+Copy;
                                Console.WriteLine($"La cadena quedo de la siguiente manera \"{CadenaOri}\"");
                            }        
                            break;
                        }

                    case 10:
                        {
                            Console.WriteLine("Ingrese la frase o palabra que quiere incluir en la cadena");
                            String Incluir = Console.ReadLine();

                            Console.WriteLine($"En que parte de la cadena la quiere colocar, la cadena es esta \"{CadenaOri}\" ");
                            int Indice = int.Parse(Console.ReadLine());

                            CadenaOri = CadenaOri.Insert(Indice, Incluir);
                            Console.WriteLine($"La nueva cadena es esta {CadenaOri}");
                            break;
                        }

                    case 11:
                        {
                            Console.WriteLine("Cual letra quiere saber su ultima ubicacion dentro de la cadena");
                            string Letra = Console.ReadLine();

                            Console.WriteLine($"La ultima {Letra} dentro de la cadena se encuentra en la posicion {CadenaOri.LastIndexOf(Letra)}");
                            break;
                        }

                    case 12:
                        {
                            Console.WriteLine($"La cadena tiene {CadenaOri.Length} posiciones para que se puedan insertar algo debe ser mayor a ese numero");
                            int EspaIz = int.Parse(Console.ReadLine());
                            Console.WriteLine("Que letra va a ingresar a la parte de la izquierda para la cadena");
                            char Nuevo = char.Parse(Console.ReadLine());

                            CadenaOri = CadenaOri.PadLeft(EspaIz, Nuevo);
                            Console.WriteLine($"La nueva cadena es esta \"{CadenaOri}\"");
                            break;
                        }

                    case 13:
                        {
                            Console.WriteLine($"La cadena tiene {CadenaOri.Length} posiciones para que se puedan insertar algo debe ser mayor a ese numero");
                            int EspaIz = int.Parse(Console.ReadLine());
                            Console.WriteLine("Que letra va a ingresar a la parte de la derecha para la cadena");
                            char Nuevo = char.Parse(Console.ReadLine());

                            CadenaOri = CadenaOri.PadRight(EspaIz, Nuevo);
                            Console.WriteLine($"La nueva cadena es esta \"{CadenaOri}\"");
                            break;
                        }

                    case 14:
                        {
                            Console.WriteLine($"La cadena es esta {CadenaOri} y tiene {CadenaOri.Length}");
                            Console.WriteLine("Borrar despues del caracter");
                            int Borrar1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("¿Cantidad a borrar?");
                            int Borrar2 = int.Parse(Console.ReadLine());

                            CadenaOri = CadenaOri.Remove(Borrar1, Borrar2);
                            Console.WriteLine($"La cadena quedo asi \"{CadenaOri}\"");
                            break;
                        }

                    case 15:
                        {
                            Console.WriteLine($"Que letra desea remplazar de la cadena {CadenaOri}?");
                            char Remplazo1 = char.Parse(Console.ReadLine());

                            Console.WriteLine($"¿Que desea ingresar en el lugar de la {Remplazo1}?");
                            char Remplazo2 = char.Parse(Console.ReadLine());

                            CadenaOri = CadenaOri.Replace(Remplazo1, Remplazo2);

                            Console.WriteLine($"La cadena quedo asi = {CadenaOri}");
                            break;
                        }

                    case 16:
                        {
                            Console.WriteLine($"La cadena es esta {CadenaOri}");
                            string[] word = CadenaOri.Split();

                            Console.WriteLine($"Y quedo asi:");
                            foreach (var words in word)
                            {
                                Console.WriteLine($"- {words}");
                            }

                            break;
                        }

                    case 17:
                        {
                            Console.WriteLine($"La cadena es esta {CadenaOri}");
                            CadenaOri = CadenaOri.ToLower();

                            Console.WriteLine($"Se paso a minusculas quedo asi {CadenaOri}");

                            break;
                        }

                    case 18:
                        {
                            Console.WriteLine($"La cadena es esta {CadenaOri}");
                            CadenaOri = CadenaOri.ToUpper();

                            Console.WriteLine($"Se paso a MAYUSCULAS quedo asi {CadenaOri}");

                            break;
                        }

                    case 19:
                        {
                            Console.WriteLine($"¿Que caracter desea eliminar de la cadena? === Cadena: {CadenaOri}");
                            char Caracter1 = char.Parse(Console.ReadLine());

                            CadenaOri = CadenaOri.Trim(Caracter1);
                            Console.WriteLine($"Asi quedo la cadena \"{CadenaOri}\"");
                            break;
                        }

                    case 20:
                        {
                            Console.WriteLine($"La cadena es {CadenaOri}");

                            char[] Carac1 = CadenaOri.ToCharArray();
                            char first = Carac1[0];
                            CadenaOri = CadenaOri.TrimStart(first);
                            Console.WriteLine($"Cadena actualizada = {CadenaOri}");
                            break;
                        }

                    case 21:
                        {
                            Console.WriteLine($"La cadena es {CadenaOri}");

                            char[] Carac1 = CadenaOri.ToCharArray();
                            char End = Carac1[CadenaOri.Length - 1];
                            CadenaOri = CadenaOri.TrimEnd(End);
                            Console.WriteLine($"Cadena actualizada = {CadenaOri}");
                            break;
                        }

                    case 22:
                        {
                            Console.WriteLine("Que es lo que desea ingresar a la cadena de texto");
                            string Agregar = Console.ReadLine();

                            System.Text.StringBuilder Sb = new System.Text.StringBuilder(CadenaOri);
                            Sb.Append(Agregar);
                            CadenaOri = $"{Sb}";

                            Console.WriteLine($"La cadena se actualizo, ahora es esta \"{CadenaOri}\"");
                            break;
                        }

                    case 23:
                        {
                            Console.WriteLine("Que es lo que desea agregar a la cadena de texto");
                            string Agregar = Console.ReadLine();

                            System.Text.StringBuilder Sc = new System.Text.StringBuilder(CadenaOri);
                            Sc.AppendFormat(Agregar);
                            CadenaOri = $"{Sc}";

                            Console.WriteLine($"La cadena se actualizo, ahora es esta \"{CadenaOri}\"");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("----------------");
                            Console.WriteLine("OPCION NO VALIDA");
                            Console.WriteLine("----------------");
                            break;
                        }

                }

                Console.WriteLine("----------------------------------");
                Console.WriteLine("¿Desea utilizar otro metodo para la cadena? (s/n)");
                WhileLoop = Console.ReadLine();

            } while (WhileLoop == "S" || WhileLoop == "s");

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"La cadena original = {CadenaOriginal} se transformo a = {CadenaOri}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Fin del programa :D");
        }
    }
}
