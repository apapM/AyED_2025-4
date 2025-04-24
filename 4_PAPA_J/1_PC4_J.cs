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

            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            bool sigueVivo = true;
            Random rand = new Random();

            while (sigueVivo)
            {
                dia = +1;
                Console.WriteLine("=== Día " + dia + " – ¿Qué querés hacer? === \n\n 1. Buscar comida \n 2. Dormir \n 3. Explorar la isla \n 4. Ver estado del personaje \n 5. Salir del juego");
                int opcion = int.Parse(Console.ReadLine());

                case(1);
                    if (opcion == 1)
                {

                }
            }
        
            
        }
    }
}
