using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;
namespace ES.DAL.Interfaces
{
   public interface IEncargado
    {
        // InsertarEncargado
        void InsertarEncargado(TB_Encargados Encargado);


        List<Encargado> ListaEncargado();
        // Select por PK
        Encargado BuscarEncargado(string cedula);
        // Update
        void ActualizarEncargado(Encargado encargado);
        // Delete
        void EliminarEncargado(int idEncargado);
        
    }
}
