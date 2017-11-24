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
        List<Profesor> ListaProfesor();
        // Select por PK
        Profesor BuscarProfesor(int idProfesor);
        // Insert
        void InsertarProfesor(Profesor profesor);
        // Update
        void ActualizarProfesor(Profesor profesor);
        // Delete
        void EliminarProfesor(int idProfesor);
    }
}
