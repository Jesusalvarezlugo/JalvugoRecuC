using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalvugoRecuC.Dtos
{
    /// <summary>
    /// Clase para la entidad propietario
    /// </summary>
    internal class PropietarioDto
    {
        //Atributos

        long idPropietario;
        string dni="aaaaaa";
        DateTime fechaCompra=DateTime.Now;
        string matriculaProp = "aaaaa";
        int esHistorico=0;

        

        //Getters y Setters
        public long IdPropietario { get => idPropietario; set => idPropietario = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public string MatriculaProp { get => matriculaProp; set => matriculaProp = value; }
        public int EsHistorico { get => esHistorico; set => esHistorico = value; }

        public PropietarioDto()
        {

        }

        public PropietarioDto( string dni, DateTime fechaCompra)
        {   
            this.dni = dni;
            this.fechaCompra = fechaCompra;          
        }

        /// <summary>
        /// Metodo ToString
        /// </summary>
        /// <returns>devuelve el texo</returns>
        override
            public string ToString()
        {
            string texto = String.Concat("Nuevo propietario: ",this.idPropietario,"-",this.dni);

            return texto;
        }
    }
}
