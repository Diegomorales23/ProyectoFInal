using ES.DATA;

namespace ES.DAL.Interfaces
{
    public interface ICursos_Profesores
    {
        // Insertar()
        void Insertar(TB_Cursos_Profesores NuevaRel);

        // Eliminar()
        void Eliminar(int Id);
    }
}
