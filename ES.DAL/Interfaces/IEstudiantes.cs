using ES.DATA;

namespace ES.DAL.Interfaces
{
    public interface IEstudiantes
    {
        // GetInfo()
        TB_Estudiantes[] GetInfo();
        
        // GetCant()
        int GetCant();

        // Insertar()
        void Insertar(TB_Estudiantes Estudiante);

        // Eliminar()
        void Eliminar(string Id);

        // Buscar()
        TB_Estudiantes[] Buscar(string Id);

        // Actualizar()
        void Actualizar(TB_Estudiantes Estudiante);
    }
}
