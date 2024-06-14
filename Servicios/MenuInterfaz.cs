using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalvugoRecuC.Servicios
{
    /// <summary>
    /// Interfaz que contiene la cabecera de los metodos del menu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu y recoge la opcion que introduce el usuario
        /// </summary>
        /// <returns>devuelve la opcion introducida por el usuario</returns>
        public int mostrarMenuYSeleccion();
    }
}
