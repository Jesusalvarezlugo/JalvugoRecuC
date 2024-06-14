using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalvugoRecuC.Utils
{
    /// <summary>
    /// Clase para metodos de utilidad 
    /// </summary>
    internal class Utilidades
    {
        /// <summary>
        /// Metodo que crea el nombre del fichero log
        /// </summary>
        /// <returns>devuelve el nombre del fichero log</returns>
        public static string nombreFicheroLog()
        {
            DateTime fechaActual= DateTime.Now;

            string nombreFich = String.Concat("log-",fechaActual.ToString("ddMMyyyy"),".txt");

            return nombreFich;
        }
    }
}
