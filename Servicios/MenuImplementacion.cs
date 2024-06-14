using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalvugoRecuC.Servicios
{
    /// <summary>
    /// Clase que contiene los menus de la aplicacion
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion;

            Console.WriteLine("#####################");
            Console.WriteLine("0. Salir de la aplicacion");
            Console.WriteLine("1. numero de historicos");
            Console.WriteLine("2. Alta nuevo propietario");
            Console.WriteLine("#####################");
            Console.WriteLine("Elija una opcion: ");
            opcion=Console.ReadKey(true).KeyChar-('0');

            return opcion;
        }
    }
}
