using ServiceStack.DataAnnotations;

namespace ES.DATA
{
    public class TB_Cursos
    {
        [AutoIncrement]
        public int ID_CUR { get; set; }

        public int ID_NIVEL { get; set; }

        public int ID_MATERIA { get; set; }
    }
}
