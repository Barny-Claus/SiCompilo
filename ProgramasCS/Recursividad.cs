using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_8___Ejemplo_recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {

                Console.Write("Elija hacia qué desea hacer:\n" +
                    "1.-Saber la suma del valor en caractéres de una palabra\n" +
                    "2.-Salir\n");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Escriba la palabra de la cual desea conocer el valor total de sus caracteres:");
                        string palabra = Console.ReadLine();
                        int letra = palabra.Length - 1;
                        Console.WriteLine(ValorPalabra(palabra, letra).ToString());
                        Console.WriteLine("Presione cualquier tecla para regresar al menú");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("elija una opción válida.");
                        Console.Clear();
                        break;
                }
            } while (opcion != 2);
        }
        private static int ValorPalabra(string palabra, int letra)
        {
            if (letra >= 0)
            {
                int total;

                char[] saluchar = palabra.ToCharArray();//Método que convierte una cadena string en un array de char directamente
                //Suma cada caracter del arreglo "char" en que se convirtió el string
                total = (saluchar[letra]) + (ValorPalabra(palabra, (letra - 1)));

                return total;
            }
            else return 0;
        }
    }
}
