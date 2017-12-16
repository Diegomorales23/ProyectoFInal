using ServiceStack.DataAnnotations;

namespace ES.DATA
{
    public class TB_Cursos_Profesores
    {
        [AutoIncrement]
        public int ID_C { get; set; }

        public int ID_CURSO { get; set; }

        public string ID_PROFESOR { get; set; }
    }
}
