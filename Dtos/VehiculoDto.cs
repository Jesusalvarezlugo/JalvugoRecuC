using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalvugoRecuC.Dtos
{
    /// <summary>
    /// Clase para el entidad vehiculo
    /// </summary>
    internal class VehiculoDto
    {
        //Atributos

        long idVehiculo;
        string matricula = "aaaaa";
        DateTime fechaMatriculacion=DateTime.Now;

        public long IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime FechaMatriculacion { get => fechaMatriculacion; set => fechaMatriculacion = value; }
    }
}
