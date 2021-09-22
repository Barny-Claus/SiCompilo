using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosicionDelReyAjedrez
{
    class Program
    {
        static void Main(string[] args)
        {
            char posiH;
            int posiv;
            int opcion;

            //Introducir la posición inicial
            Console.Write("Escriba la posición inicial de su rey:");
            string coordenadas = Console.ReadLine();
            string[] coordenada = coordenadas.Split(' ');
            posiH = Convert.ToChar(coordenada[0]);
            posiv = Convert.ToInt32(coordenada[1]);
            if (posiH > 'h' || posiv > 9)
            {
                Console.WriteLine("No es una coordenada existente en un tablero de ajedrez");
                Console.ReadKey();
            }
            else
            { 
                do
                {
                    //Moverse
                    Console.WriteLine("Elija hacia qué dirección quiere ir:\n" +
                    "1.-Subir\n" +
                    "2.-Bajar\n" +
                    "3.-Izquierda\n" +
                    "4.-Derecha\n" +
                    "5.-Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());
                //
                    switch (opcion)
                    {
                        //subir
                        case 1:
                            if (posiv <= 8)
                            {
                                posiv = posiv + 1;
                                Console.WriteLine("Su movimiento fue:");
                                Console.Write("R");
                                Console.Write(posiH);
                                Console.WriteLine(posiv);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else { Console.WriteLine("No es un movimiento legal pues saldrías del tablero");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        
                            break;
                        //bajar
                        case 2:
                            if (posiv >= 1)
                            {
                                posiv = posiv - 1;
                                Console.WriteLine("Su movimiento fue:");
                                Console.Write("R");
                                Console.Write(posiH);
                                Console.WriteLine(posiv);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else { Console.WriteLine("No es un movimiento legal pues saldrías del tablero");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        //Izquierda
                        case 3:

                            if (posiH != 'a')
                            {
                                Convert.ToInt32(posiH);
                                int nposiH = posiH - 1;

                                Console.WriteLine("Su movimiento fue:");
                                Console.Write("R");
                                Console.Write((char)nposiH);
                                Console.WriteLine(posiv);
                                posiH =(char)nposiH;
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else { Console.WriteLine("No es un movimiento legal pues saldrías del tablero");
                                Console.ReadKey();
                                Console.Clear();
                            }
                                
                            break;
                        //Derecha
                        case 4:
                            if (posiH != 'h')
                            {
                                Convert.ToInt32(posiH);
                                int nposiH = posiH + 1;

                                Console.WriteLine("Su movimiento fue:");
                                Console.Write("R");
                                Console.Write((char)nposiH);
                                Console.WriteLine(posiv);
                                posiH = (char)nposiH;
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else { Console.WriteLine("No es un movimiento legal pues saldrías del tablero");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            
                            break;
                        default:
                            Console.WriteLine("Ese movimiento no está disponible en la versión gratis, descargue " +
                                "premium para hacerlo xd");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                
                } while (opcion != 5);
                Console.ReadKey();
            }
        }
    }
}
