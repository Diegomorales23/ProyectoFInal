using ES.DATA;
using System.Collections.Generic;

namespace ES.DAL.Interfaces
{
    public interface ICursos
    {
        // Insertar()
        void Insertar(TB_Cursos NuevoCurso);

        // GetCant()
        int GetCant();

        // GetInfo()
        List<tempCursos> GetInfo();

        // Eliminar()
        void Eliminar(int Id);
    }
}
