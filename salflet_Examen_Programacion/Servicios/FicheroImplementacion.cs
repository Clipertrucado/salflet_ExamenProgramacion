using salflet_Examen_Programacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet_Examen_Programacion.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void crearListaFichero()
        {
            string fichero = leerFichero();
            string[] ficheroArray = crearArray(fichero);
            anyadirLista(ficheroArray);
        }

        /// <summary>
        /// con este metod leeremos el fichero
        /// sav - 300425
        /// </summary>
        /// <returns></returns>
        private string leerFichero() {

            string ruta = "C:\\Users\\csi23-salflet\\source\\repos\\salflet_Examen_Programacion\\Ficheros\\Citas.txt";
            string fichero;

            using (StreamReader sr = new StreamReader(ruta))
            {

                fichero = sr.ReadToEnd();

            }

            return fichero;

        }

        /// <summary>
        /// con este metodo separamso el string por linea 
        /// sav - 300425
        /// </summary>
        /// <param name="fichero"> texto completo del fichero</param>
        /// <returns></returns>
        private string[] crearArray(string fichero) {

            string[] ficheroArray = fichero.Split('\n');

           
            
           return ficheroArray;
        }

        /// <summary>
        /// Por ultimo añadimos cada cita a la lista 
        /// sav - 300425
        /// </summary>
        /// <param name="ficheroArray"></param>
        private void anyadirLista(string[] ficheroArray) {
        
            for (int i = 0; i < ficheroArray.Length -1; i++ ) {
                CitaDto cita = new CitaDto();
                string[] citaDatos = ficheroArray[i].Split(";");

                cita.DniPacienteCita = citaDatos[0];
                cita.NombrePacienteCita = citaDatos[1];
                cita.ApellidoPacienteCita= citaDatos[2];
                cita.EspecialistaCita = citaDatos[3];
                cita.FechaConsulta= Convert.ToDateTime(citaDatos[4]);
                cita.AsistenciaCita = Convert.ToBoolean(citaDatos[5]);

                Controladores.Program.listaCitas.Add(cita);
                

            }
        
        }
        
    }
}
