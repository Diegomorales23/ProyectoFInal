using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;

namespace ES.DAL.Interfaces
{
   public interface IRoles
    {
        List<Roles> ListarRoles();
        Roles BuscarRoles(int idRoles);
        //INSERT
        void InsertarRoles(Roles roles);
        //UPDATE
        void ActualizarRoles(Roles roles);
        //DELETE
        void EliminarRoles(int idroles);

    }
}
