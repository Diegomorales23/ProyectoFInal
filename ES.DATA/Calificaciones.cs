using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ES.DATA
{
    public class Calificaciones
    {
        [AutoIncrement]
        public int IdCalificaciones { get; set; }
      
        public int IdMateria { get; set; }

        public int idAlumno { get; set; }

        public int? ITrimestre { get; set; }

        public int? IITrimestre { get; set; }

        public int? IIITrimestre { get; set; }

        public int? NotaFinal { get; set; }

        public int? IConvocatoria { get; set; }

        public int? IIConvocatoria { get; set; }

    }

}
