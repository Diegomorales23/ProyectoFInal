using ServiceStack.DataAnnotations;

namespace ES.DATA
{
    public class TB_Materias
    {
        [AutoIncrement]
        public int ID_MATERIA { get; set; }

        public string NOMBRE { get; set; }
    }
}
