using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet_Examen_Programacion.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuSeleccion()
        {
            
            Console.WriteLine("-----------------------");
            Console.WriteLine("         Menu");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Registro de llegada");
            Console.WriteLine("2. Lista de consultas");
            Console.WriteLine("0. Cerra");

            int seleccion = Convert.ToInt32(Console.ReadLine());

            return seleccion;
        }

        public int submenuSeleccion()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("  Listado consultas");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Mostrar Consultas");
            Console.WriteLine("2. imprimir Consultas");
            Console.WriteLine("0. Cerra");

            int seleccion = Convert.ToInt32(Console.ReadLine());

            return seleccion;
        }
    }
}
