using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalvugoRecuC.Servicios
{
    /// <summary>
    /// Interfaz de los ficheros
    /// </summary>
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Metodo para la carga inicial
        /// </summary>
        /// <param name="ruta"></param>
        public void leerFichero(string ruta);

        /// <summary>
        /// Metodo para escribir en el fichero log
        /// </summary>
        /// <param name="texto"></param>
        public void escribirEnFicheroLog(string texto);
    }
}
