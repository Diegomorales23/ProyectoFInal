﻿using ServiceStack.DataAnnotations;

namespace ES.DATA
{
    public class TB_Niveles
    {
        [AutoIncrement]
        public int ID_NIVEL { get; set; }

        public string NOMBRE { get; set; }
    }
}