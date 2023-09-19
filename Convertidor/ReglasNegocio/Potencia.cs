using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor.ReglasNegocio
{
    internal class Potencia
    {
        // clase estatica para no tener que instanciar la clase
        public static string Calcular(int base1, int potencia) 
        {
            // retorna un string con el resultado del metodo pow de la clase math
            return Math.Pow(base1, potencia).ToString();
        }
    }
}
