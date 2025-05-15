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
            Console.WriteLine("Prepara tu fiesta soñada. Cuantos aliens amigos vas a invitar?");
            int invitados = int.Parse(Console.ReadLine());

            int[] guest = new int[invitados];
            int panchos = 0;
         

            for (int i = 0; i < invitados; i++)
            {
                Console.WriteLine("Cuantos panchitos come el invitado N " + (i + 1) + " ?");
                guest[i] = int.Parse(Console.ReadLine());
             
                panchos = panchos + guest[i];

            }

            int promedio = panchos / invitados;

            Console.WriteLine("en total son " + panchos + " panchos. Cada invitado va a comer " + promedio + " panchos.");
            Console.ReadLine();

        }
    }
}






/* Lilo está organizando una fiesta para los aliens invitados por Stitch y necesita gestionar 
            * la cantidad de comida necesaria. Para ello, ha creado un programa en C# que le ayudará a calcular
            *  el promedio de comida que necesitará por invitado. El programa solicitará al usuario que 
            *  ingrese la cantidad de invitados y luego pedirá la cantidad de comida que cada invitado consume,
            *   asegurándose de que los valores ingresados estén dentro del rango permitido (de 1 a 100). 
            *   Una vez que se hayan ingresado todos los datos, el programa calculará el promedio de comida por invitado 
            *   y lo mostrará en pantalla.*/
