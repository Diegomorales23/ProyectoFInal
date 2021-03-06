﻿using ServiceStack.DataAnnotations;
using System;

namespace ES.DATA
{
    public class TB_Notas
    {
        [AutoIncrement]
        public int ID_NOTAS { get; set; }

        public string ID_ESTUDIANTE { get; set; }

        public int ID_CURSO { get; set; }

        public int? PRIMER_PERIODO { get; set; }

        public int? SEGUNDO_PERIODO { get; set; }

        public int? TERCER_PERIODO { get; set; }

        public int? CONVOCATORIA_I { get; set; }

        public int? CONVOCATORIA_II { get; set; }

        public int? CONVOCATORIA_III { get; set; }

        public int? PROMEDIO { get; set; }

        public string PROMOCION { get; set; }
    }
}
