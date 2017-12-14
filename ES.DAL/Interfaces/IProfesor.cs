using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;
namespace ES.DAL.Interfaces
{
   public interface IProfesor
    {
        List<TB_PROFESOR> ListaProfesor();
        // Select por PK
        TB_PROFESOR BuscarProfesor(int idProfesor);
        // Insert
        void InsertarProfesor(TB_PROFESOR profesor);
        // Update
        void ActualizarProfesor(TB_PROFESOR profesor);
        // Delete
        void EliminarProfesor(int idProfesor);
    }
}
