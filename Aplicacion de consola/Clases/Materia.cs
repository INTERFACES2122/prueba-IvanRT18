using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_consola.Clases
{
    
    public class Materia
    {
        /// <summary>
        /// Variable del nombre de al materia
        /// </summary>
        /// int x;
        private string nombre;
        private int no_alumnos;
        //definimos como se va a comportar la variable codigo
        public string Codigo { get; set; }

        /// <summary>
        /// Metodo de acceso dela tributo nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }

        }

        public int NoAlumnos
        {
            get
            {
                return no_alumnos;
            }
            set
            {
                no_alumnos = value;
            }
        }
}
