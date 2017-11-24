using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;

namespace ES.DAL.Interfaces
{
  public interface IGrupo
    {
        List<Grupo> ListarGrupo();
        Grupo BuscarGrupo(int idgrupo);
        //INSERT
        void InsertarGrupo(Grupo grupo);
        //UPDATE
        void ActualizarGrupo(Grupo grupo);
        //DELETE
        void EliminarGrupo(int idgrupo);

    }
}
