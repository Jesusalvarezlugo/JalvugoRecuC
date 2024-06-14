using JalvugoRecuC.Dtos;
using JalvugoRecuC.Servicios;
using JalvugoRecuC.Utils;
using static System.Net.Mime.MediaTypeNames;

namespace JalvugoRecuC.Controladores
{
    /// <summary>
    /// Clase por la que entra el flujo de la aplicacion
    /// </summary>
    class Program
    {
        

        public static string carpetaLog = "C:\\Users\\Jesús\\source\\repos\\JalvugoRecuC\\Logs\\";
        public static string rutaFicheroLog=String.Concat(carpetaLog,Utilidades.nombreFicheroLog());
        public static List<VehiculoDto> listaVehiculos = new List<VehiculoDto>();
        public static List<PropietarioDto> listaPropietarios = new List<PropietarioDto>();
        /// <summary>
        /// metodo por el que se llama a los metodos externos 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int opcion;
            bool cerrarMenu = false;
            MenuInterfaz mi = new MenuImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            string rutaFichero = "datosIniciales.txt";
            
            fi.leerFichero(rutaFichero);

            while (!cerrarMenu)
            {
                try
                {
                    opcion = mi.mostrarMenuYSeleccion();

                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("Se saldra de la aplicacion.");
                            fi.escribirEnFicheroLog("Se saldra de la aplicacion.");
                            cerrarMenu=true;
                            break;

                        case 1:
                            Console.WriteLine("Numero de historicos");
                            fi.escribirEnFicheroLog("Numero de historicos");
                            oi.numeroDeHistoricos();
                            break;

                        case 2:
                            Console.WriteLine("Alta nuevo propietario.");
                            fi.escribirEnFicheroLog("Alta nuevo propietario");
                            oi.crearCliente();

                            foreach(PropietarioDto propietario in listaPropietarios)
                            {
                                if (propietario.IdPropietario == 0)
                                {
                                    propietario.IdPropietario = oi.autoIdProp();
                                }
                                Console.WriteLine(propietario.ToString());
                            }
                            break;

                        default:
                            fi.escribirEnFicheroLog("opcion introducida no valida");
                            break;
                    }
                }catch(Exception ex)
                {
                    fi.escribirEnFicheroLog("Error en alguna funcionalidad del menu");
                }
            }

            
        }
    }
}
