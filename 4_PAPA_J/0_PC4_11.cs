using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Escriba un programa en C# que solicite el ancho (x) y 
            la altura (y) de un rectángulo y calcule el perímetro, el área y la diagonal. */

            Console.WriteLine("Dame el ancho de tu rectangulo: ");
            double ancho = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame el alto de tu rectangulo: ");
            double alto = int.Parse(Console.ReadLine());

            double area = alto * ancho;
            double perimetro = alto * 2 + ancho * 2;
            double diagonal = Math.Sqrt(ancho * ancho) + (alto * alto);
            

            Console.WriteLine("La diagonal de tu rectangulo es de: " + diagonal + "CM, su perimetro es de: " + perimetro + "CM, y su area es de: " + area + "CM.");
            Console.ReadLine();
        }
    }
}
