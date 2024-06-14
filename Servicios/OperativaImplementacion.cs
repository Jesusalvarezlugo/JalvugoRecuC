using JalvugoRecuC.Controladores;
using JalvugoRecuC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalvugoRecuC.Servicios
{
    /// <summary>
    /// clase que contiene la operativa de la aplicacion
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void crearCliente()
        {
            PropietarioDto propietarioNuevo = nuevoPropietario();

            Program.listaPropietarios.Add(propietarioNuevo);
        }

        private PropietarioDto nuevoPropietario()
        {
            PropietarioDto propietario = new PropietarioDto();

            propietario.IdPropietario = autoIdProp();
            Console.WriteLine("Introduzca el dni del propietario: ");
            propietario.Dni = Console.ReadLine();

            while (propietario.Dni.Length != 9)
            {
                Console.WriteLine("[Error] el dni no esta formado por nueve caracteres, introduzcalo de nuevo:");
                propietario.Dni = Console.ReadLine();
            }

            return propietario;


        }

        /// <summary>
        /// Metodo para el nuevo id del propietario
        /// </summary>
        /// <returns>el id nuevo</returns>
        public long autoIdProp()
        {
            long nuevoId;
            int tamanioLista=Program.listaPropietarios.Count();

            if (tamanioLista > 0)
            {
                nuevoId = Program.listaPropietarios[tamanioLista - 1].IdPropietario + 1;
            }
            else
            {
                nuevoId = 1;
            }

            return nuevoId;
        }

        public void numeroDeHistoricos()
        {
            DateTime fechaActual= DateTime.Today;
            
            int aux=0;
            foreach(PropietarioDto propietario in Program.listaPropietarios)
            {
                //Console.WriteLine(fechaActual.Year - propietario.FechaCompra.Year);
                if (fechaActual.Year - propietario.FechaCompra.Year > 25)
                {

                    aux = propietario.EsHistorico+1;
                    
                    
                }
            }

            Console.WriteLine(String.Concat("N. Historicos:",aux));
        }
    }
}
