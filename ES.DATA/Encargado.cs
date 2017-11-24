using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DATA
{
    public class Encargado
    {
        [AutoIncrement]
        public int IdEncargado { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }

        

    }
}
