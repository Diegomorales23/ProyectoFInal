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


        // GetCantEstudiantes()
        public int GetCantEstudiantes()
        {
            return _est.GetCantEstudiantes();
        }
        
        public void InsertarEstudiante(TB_Estudiantes Estudiante)
        {
            _est.InsertarEstudiante(Estudiante);
        }

        public void EliminarEstudiante(string IdEstudiante)
        {
            _est.EliminarEstudiante(IdEstudiante);
        }

        public TB_Estudiantes[] BuscarEstudiante(string IdEstudiante)
        {
            return _est.BuscarEstudiante(IdEstudiante);
        }

        public void ActualizarEstudiante(TB_Estudiantes Estudiante)
        {
            _est.ActualizarEstudiante(Estudiante);
        }

    }
}
