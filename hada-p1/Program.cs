using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main()
        {
            string opcion;

            do
            {
                Console.WriteLine("¿Convertir desde (s) segundos o (m) minutos?");
                string unidad = Console.ReadLine();

                Console.WriteLine("Introduce cantidad:");
                double valor = double.Parse(Console.ReadLine());

                if (unidad == "s")
                    Console.WriteLine(HadaP1.Seconds2Minutes(valor) + " minutos");
                else
                    Console.WriteLine(HadaP1.Minutes2Seconds(valor) + " segundos");

                Console.WriteLine("¿Otra conversión? (y/n)");
                opcion = Console.ReadLine();

            } while (opcion == "y");
        }
    }
}
