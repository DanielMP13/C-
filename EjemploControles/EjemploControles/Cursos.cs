using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploControles
{
    internal class Cursos
    {
        public int Codigo { get; set; }
        public string Curso { get; set; }
        public string Familia { get; set; }
        public string Poblacion { get; set; }
        public string Colectivo { get; set; }
        public bool Certificado { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Ruta { get; set; }
    }
}
