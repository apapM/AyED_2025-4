﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que pida al usuario dos números
             *  y muestre por pantalla su división. Si el divisor es cero el programa debe mostrar un error.*/

            Console.WriteLine("Decime un numero: ");
            double num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Decime otro numero: ");
            double num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Error matemático.");
                Console.ReadLine();
            }
            else
            {
                double resultado = num1 / num2;
                Console.WriteLine("El resultado es: " + resultado);
                Console.ReadLine();
            }
        }
    }
}

