using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_consola
{
    /// <summary>
    /// Esta es una clase para un alumno
    /// </summary>
    public class Alumno
    {
        private string cve_unica;
        private string nombres;
        private string apellidos;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Alumno()
        { }

        /// <summary>
        /// Constructor de la clase que asigna informacion incial
        /// </summary>
        /// <param name="_cve_unica">Clave unica</param>
        /// <param name="_nombres">Nombres(s) del alumno</param>
        /// <param name="_apellidos">Apellidos del alumno</param>
        public Alumno(string _cve_unica, string _nombres, string _apellidos)
        {
            cve_unica = _cve_unica;
            nombres = _nombres;
            apellidos = _apellidos;
        }

        /// <summary>
        /// Obtiene la informacion del alumno en una sola variable
        /// </summary>
        /// <returns></returns>
        public string ObtenerInformacion()
        {
            string informacion = "";

            informacion = cve_unica + " - " + nombres " " + apellidos;

            return informacion;
        }
    }
}
