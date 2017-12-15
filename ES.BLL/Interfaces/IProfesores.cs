using ES.DATA;

namespace ES.BLL.Interfaces
{
    public interface IProfesores
    {
        // GetInfo()
        TB_Profesores[] GetInfo();

        // GetCant()
        int GetCant();

        // Insertar()
        void Insertar(TB_Profesores Profesor);

        // Eliminar()
        void Eliminar(string Id);

        // Buscar()
        TB_Profesores[] Buscar(string Id);

        // Actualizar()
        void Actualizar(TB_Profesores Profesor);
    }
}
