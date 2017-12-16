namespace ES.DATA
{
    public class TB_Estudiantes
    {
        public string ID_ESTUDIANTE { get; set; }

        public string ID_ENCARGADO { get; set; }

        public string ID_SECCION { get; set; }

        public int ID_NIVEL { get; set; }

        public string NOMBRE { get; set; }

        public string APELLIDOS { get; set; }

        public string TELEFONO { get; set; }

        public string EMAIL { get; set; }

        public string PADECIMIENTOS { get; set; }

        public string DIRECCION { get; set; }

        public bool? GRADUADO { get; set; }

        public bool? ABANDONO { get; set; }

        public string ANO_GRADUACION { get; set; }
    }
}
