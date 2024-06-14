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
    /// Clase para la operativa de los ficheros
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void escribirEnFicheroLog(string texto)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Program.rutaFicheroLog,true);

                sw.WriteLine(texto);

                sw.Close();
            }catch(IOException e)
            {
                Console.WriteLine("Error al escribir en el fichero log");
            }
        }

        public void leerFichero(string ruta)
        {
            try
            {
                string[] lineas = File.ReadAllLines(ruta);
                //string dniProp;
                //DateTime fechaCompra;
                foreach(string linea in lineas)
                {
                    string[] datosVeh = linea.Split(":");
                    VehiculoDto vehiculo = new VehiculoDto();
                    PropietarioDto propietario = new PropietarioDto();
                    vehiculo.Matricula = datosVeh[0];
                    vehiculo.FechaMatriculacion = Convert.ToDateTime(datosVeh[1]).Date;
                    propietario.Dni = datosVeh[2];
                    propietario.FechaCompra = Convert.ToDateTime(datosVeh[3]).Date;
                    Program.listaVehiculos.Add(vehiculo);
                    Program.listaPropietarios.Add(propietario);
                }
            }catch(IOException e)
            {
                escribirEnFicheroLog("[Error] al leer la carga inicial");
            }
        }
    }
}
