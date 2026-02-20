using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///Programa principal
namespace hada_p1
{
    class Program
    {
        static void Main()
        {
            string opcion;

            do
            {
                Console.WriteLine("¿Convertir desde (s) segundos o (m) minutos o (h) horas?");
                string unidad = Console.ReadLine();

                Console.WriteLine("Introduce cantidad:");
                double valor = double.Parse(Console.ReadLine());

                if (unidad == "s")
                    Console.WriteLine(HadaP1.Seconds2Minutes(valor) + " minutos");
                else if (unidad == "m")
                    Console.WriteLine(HadaP1.Minutes2Seconds(valor) + " segundos");
                else
                    Console.WriteLine(HadaP1.HorasAMinutos(valor) + " horas");

                    Console.WriteLine("¿Otra conversión? (y/n)");
                opcion = Console.ReadLine();

            } while (opcion == "y");
        }
    }
}
