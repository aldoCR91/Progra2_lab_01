using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor.ReglasNegocio
{
    internal class Potencia
    {
        public static string Calcular(int base1, int potencia) 
        {
            return Math.Pow(base1, potencia).ToString();
        }
    }
}
