using Microsoft.VisualBasic;
using salflet_Examen_Programacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet_Examen_Programacion.Servicios
{
    internal class OperativaImplementacion : OperaticaInterfaz
    {
        public void mostrarConsultas()
        {
            DateTime dia = pedirDia();
            caluloListaFecha(dia);
        }

        /// <summary>
        /// con este metodo pedimos el dia que desea ver las citas
        /// </summary>
        /// <returns></returns>
        private DateTime pedirDia() {

            Console.WriteLine("elija una fecha (dd-MM-yyyy)");
            DateTime dia = Convert.ToDateTime(Console.ReadLine());
            
            return dia;
        
        }

        /// <summary>
        /// con este metodo veremos las citas que se desea ver segun los datos introducidos
        /// </summary>
        /// <param name="dia"></param>
        private void caluloListaFecha(DateTime dia)
        {
            Console.WriteLine("Psicología---Fisioterapia---Traumatología");
            string consulta = Console.ReadLine();

            foreach (var cita in Controladores.Program.listaCitas)
            {

                if (cita.FechaConsulta.Year == dia.Year && cita.FechaConsulta.Month == dia.Month && cita.FechaConsulta.Day == dia.Day && consulta.Equals(cita.EspecialistaCita))
                {
                    string clientecito = string.Concat(cita.DniPacienteCita, ";",
                    cita.NombrePacienteCita, ";",
                    cita.ApellidoPacienteCita, ";",
                    cita.EspecialistaCita, ";",
                    cita.FechaConsulta, ";",
                    cita.AsistenciaCita);

                    Console.WriteLine(clientecito);

                }
                
                
            }

        }

        public void imprimirConsultas()
        {
            DateTime dia = pedirDia();
            caluloListaFechaImpresion(dia);
        }

        /// <summary>
        /// encargado de calcular cuales son las citas del dia que aun no han sido 
        /// </summary>
        /// <param name="dia"></param>
        private void caluloListaFechaImpresion(DateTime dia)
        {

            string ruta = string.Concat("C:\\Users\\csi23-salflet\\source\\repos\\salflet_Examen_Programacion\\Ficheros\\citasCOnAsistencia-", DateTime.Today.ToString("ddMMyyyy"));
            

            Console.WriteLine("Psicología---Fisioterapia---Traumatología");
            string consulta = Console.ReadLine();

            foreach (var cita in Controladores.Program.listaCitas)
            {
                using (StreamWriter sw = new StreamWriter(ruta, true)) {
                    if (cita.FechaConsulta.Year == dia.Year && cita.FechaConsulta.Month == dia.Month && cita.FechaConsulta.Day == dia.Day && consulta.Equals(cita.EspecialistaCita) && cita.AsistenciaCita == true)
                    {
                        string clientecito = string.Concat("Nombre Completo: ",
                        cita.NombrePacienteCita, " ",
                        cita.ApellidoPacienteCita, ", hora: ", cita.FechaConsulta.Hour, ":", cita.FechaConsulta.Minute);




                        sw.WriteLine(clientecito);

                    }
                }


            }

        }

        public void registroLlegada()
        {
            Console.WriteLine("Introduce los numeros de su DNI");
            long nDNI = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduce la letra de su DNI");
            string lDNI = Console.ReadLine();

            string[] letra = {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"};

            

            if (letra[nDNI%23].Equals(lDNI)) {

                

                foreach (var cita in Controladores.Program.listaCitas) {
                    if (cita.DniPacienteCita.Equals(string.Concat(nDNI, lDNI)) && cita.FechaConsulta.ToString("ddMMyyyy").Equals(DateTime.Today.ToString("ddMMyyyy")) && cita.AsistenciaCita == false)
                    {

                        Console.WriteLine("Espere su turno para la consulta de " + cita.EspecialistaCita + " en la sala de espera. Su especialista le avisará.");

                    }
                    
                }
            
            
            }else
            {
                Console.WriteLine("No dispone de cita previa para hoy");
            }


        }

        
    }
}
