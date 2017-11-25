using ES.BLL.Interfaces;
using ES.DATA;

namespace ES.BLL.Metodos
{
    public class MEstudiantes : IEstudiantes
    {
        private DAL.Interfaces.IEstudiantes _est;
        public MEstudiantes()
        {
            _est = new DAL.Metodos.MEstudiantes();
        }

        // GetEstudiantesInfo()
        public TB_Estudiantes[] GetEstudiantesInfo()
        {
            return _est.GetEstudiantesInfo();
        }
    }
}
