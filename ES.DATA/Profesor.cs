using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ES.DATA
{
    public class Profesor
    {//n4l
        [AutoIncrement]
        public int IdProfesor { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Padecimientos { get; set; }

        public string Direccion { get; set; }
       
        public int IdMateria { get; set; }

        public string Cedula { get; set; }

    }

}
