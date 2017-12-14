using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DATA
{
    public class TB_PROFESOR
    {
        [AutoIncrement]
        public int Id_Profesor { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Padecimientos { get; set; }
        public string Direccion { get; set; }
    }
}
