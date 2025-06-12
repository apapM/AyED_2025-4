using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC4_TP8
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Crear una matriz de n×m con todos sus elementos inicializados a cero.  Imprimirla por pantalla*/

            int filas = 0;
            int columnas = 0;

            Console.WriteLine("ingrese cantidad de filas");

            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese cantidad de columnas");

            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            for (int f = 0; f < filas; f++)
            {

                for (int c = 0; c < columnas; c++)
                {

                    matriz[f, c] = 0;
                }
            }

            for (int f = 0; f < filas; f++)
            {

                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(matriz[f, c] + "\t");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
