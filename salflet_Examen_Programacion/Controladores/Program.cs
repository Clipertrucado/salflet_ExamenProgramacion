using salflet_Examen_Programacion.Dtos;
using salflet_Examen_Programacion.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// contiene todos los controladores 
/// </summary>
namespace salflet_Examen_Programacion.Controladores
{
    /// <summary>
    /// clase principal de nuestro proyecto
    /// sav - 300424
    /// </summary>
    internal class Program
    {

        public static List<CitaDto> listaCitas = new List<CitaDto>();

        /// <summary>
        /// metodo principal y que contiene el flujo de nuestra aplicacion
        /// sav - 300424
        /// </summary>
        static void Main() { 
            
            //aremos copias de nuestra interfacez e implementaciones 
            MenuInterfaz mi = new MenuImplementacion();
            OperaticaInterfaz oi = new OperativaImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();

            //llamamos al metodo que crea la lista principal a partir de un fichero 
            fi.crearListaFichero();
            bool cerrar = true;
            while (cerrar)
            {
                //llamamos al menu principal 
                int seleccion = mi.menuSeleccion();

                switch (seleccion) { 
                    case 0:
                        cerrar = false;
                        break;

                    case 1:
                        
                        oi.registroLlegada();
                        break;

                    case 2:
                        bool cerrarSub = true;
                        while (cerrarSub)
                        {
                            int seleccionada = mi.submenuSeleccion();
                            switch (seleccionada)
                            {
                                case 0:
                                    cerrarSub = false;
                                    break;

                                case 1:
                                    oi.mostrarConsultas();
                                    break;

                                case 2:
                                    oi.imprimirConsultas();
                                    break;
                            }
                        }
                        break;
                }
            }
        }
    }
}
