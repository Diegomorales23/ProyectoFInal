using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DATA
{
    public class Alumnos
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Padecimientos { get; set; }
        public string Direccion { get; set; }
        public string IdEncargado { get; set; }
        public bool Graduado { get; set; }
        public bool Abandono { get; set; }
        public string AñoGraduacion { get; set; }
        public string Sección { get; set; }
        public string IdProfeGuia { get; set; }
    }
}