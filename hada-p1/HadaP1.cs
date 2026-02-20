//48775002Y

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Programa principal
namespace hada_p1
{
    internal class HadaP1
    {
        ///Convierte segundos a minutos
        public static double Seconds2Minutes(double s)
        {
            if (s == 0)
                return 0;

            return s / 60;
        }

        ///Convierte minutos a segundos
        public static double Minutes2Seconds(double m)
        {
            return m * 60;
        }
    }
}
