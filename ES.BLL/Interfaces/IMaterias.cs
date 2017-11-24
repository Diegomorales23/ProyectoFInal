using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;
namespace ES.BLL.Interfaces
{
   public interface IMaterias
    {
        List<Materias> ListarMaterias();
        Materias BuscarMaterias(int idmaterias);
        //INSERT
        void InsertarMaterias(Materias materias);
        //UPDATE
        void ActualizarMaterias(Materias materias);
        //DELETE
        void EliminarMaterias(int materias);

    }
}
