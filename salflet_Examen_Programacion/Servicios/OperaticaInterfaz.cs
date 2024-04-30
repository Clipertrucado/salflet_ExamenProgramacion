using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet_Examen_Programacion.Servicios
{
    internal interface OperaticaInterfaz
    {
        /// <summary>
        /// metodo al que llamaremso para costrar las consultas del dia 
        /// sav - 300425
        /// </summary>
        public void mostrarConsultas();

        /// <summary>
        /// metodo al que llamaremso para escribir en el fichero las consultas que no han pasado 
        /// sav - 300425
        /// </summary>
        public void imprimirConsultas();

        /// <summary>
        /// metodo al que llamaremso indicarle al paciente que el dni introducedo es correcto o no y su cita
        /// sav - 300425
        /// </summary>
        public void registroLlegada();
    }
}
