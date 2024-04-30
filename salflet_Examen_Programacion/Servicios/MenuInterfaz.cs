using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet_Examen_Programacion.Servicios
{
    /// <summary>
    /// interzar que contendra la cabecera de los metodos que podremos llamar desde las instancias
    /// sav - 300424
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// encargado de mostrar el menu principal de la aplicacion y de devolver la seleccion del usuario
        /// sav - 300424
        /// </summary>
        /// <returns></returns>
        public int menuSeleccion();

        /// <summary>
        /// encargado de mostrar el submenu de la aplicacion y de devolver la seleccion del usuario
        /// sav - 300424
        /// </summary>
        /// <returns></returns>
        public int submenuSeleccion();
    }
}
