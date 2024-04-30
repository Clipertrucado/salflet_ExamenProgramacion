using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet_Examen_Programacion.Dtos
{
    /// <summary>
    /// clase destinada a almacenar mediante copias los datos de una cita
    /// </summary>
    internal class CitaDto
    {
        string dniPacienteCita = "aaaaaaaa";
        string nombrePacienteCita = "aaaaaaaa";
        string apellidoPacienteCita = "aaaaaaaa";
        string especialistaCita = "aaaaaaaa";
        DateTime fechaConsulta;
        bool asistenciaCita = false;

        /// <summary>
        /// constructor vacio 
        /// </summary>
        public CitaDto()
        {

        }

        /// <summary>
        /// constructor por parametros
        /// </summary>
        /// <param name="dniPacienteCita"></param>
        /// <param name="nombrePacienteCita"></param>
        /// <param name="apellidoPacienteCita"></param>
        /// <param name="especialistaCita"></param>
        /// <param name="fechaConsulta"></param>
        /// <param name="asistenciaCita"></param>
        public CitaDto(string dniPacienteCita, string nombrePacienteCita, string apellidoPacienteCita, string especialistaCita, DateTime fechaConsulta, bool asistenciaCita)
        {
            this.DniPacienteCita = dniPacienteCita;
            this.NombrePacienteCita = nombrePacienteCita;
            this.ApellidoPacienteCita = apellidoPacienteCita;
            this.EspecialistaCita = especialistaCita;
            this.FechaConsulta = fechaConsulta;
            this.AsistenciaCita = asistenciaCita;
        }


        //encapsulamiento
        public string DniPacienteCita { get => dniPacienteCita; set => dniPacienteCita = value; }
        public string NombrePacienteCita { get => nombrePacienteCita; set => nombrePacienteCita = value; }
        public string ApellidoPacienteCita { get => apellidoPacienteCita; set => apellidoPacienteCita = value; }
        public string EspecialistaCita { get => especialistaCita; set => especialistaCita = value; }
        public DateTime FechaConsulta { get => fechaConsulta; set => fechaConsulta = value; }
        public bool AsistenciaCita { get => asistenciaCita; set => asistenciaCita = value; }

        /// <summary>
        /// metodo toString encargado de mostrar el contenido que nosotros indiquemos cuando lo llamemso
        /// </summary>
        /// <returns></returns>
        override
        public String ToString()
        {
            string texto = string.Concat(dniPacienteCita,nombrePacienteCita,apellidoPacienteCita,especialistaCita,fechaConsulta.ToString(),asistenciaCita.ToString());

            return texto;
        }
    }
}
