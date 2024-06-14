using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalvugoRecuC.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo para crear un cliente
        /// </summary>
        public void crearCliente();

        public long autoIdProp();

        /// <summary>
        /// Metodo para mostrar los historicos
        /// </summary>
        public void numeroDeHistoricos();
    }
}
