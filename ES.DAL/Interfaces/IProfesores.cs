using ES.DATA;
using System.Collections.Generic;

namespace ES.DAL.Interfaces
{
    public interface IProfesores
    {
        // ListarProfesores();
        List<TB_Profesores> ListarProfesores();

        // GetId()
        string GetId(string NOMBRE);





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
