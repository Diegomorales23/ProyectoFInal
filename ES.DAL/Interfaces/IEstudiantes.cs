using ES.DATA;

namespace ES.DAL.Interfaces
{
    public interface IEstudiantes
    {
        // GetEstudiantesInfo()
        TB_Estudiantes[] GetEstudiantesInfo();
        
        // GetCantEstudiantes()
        int GetCantEstudiantes();

        void InsertarEstudiante(TB_Estudiantes Estudiante);

        void EliminarEstudiante(string IdEstudiante);

        TB_Estudiantes[] BuscarEstudiante(string IdEstudiante);

        void ActualizarEstudiante(TB_Estudiantes Estudiante);
    }
}
