using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.BLL.Interfaces;
using ES.DATA;
namespace ES.BLL.Metodos
{
    public class MGrupo : IGrupo
    {
        private DAL.Interfaces.IGrupo gru;
        public MGrupo()
        {
            gru = new DAL.Metodos.MGrupo();
        }

        public void ActualizarGrupo(Grupo grupo)
        {
            throw new NotImplementedException();
        }

        public Grupo BuscarGrupo(int idgrupo)
        {
            throw new NotImplementedException();
        }

        public Grupo BuscarGrupoNombre(string grupo)
        {
            throw new NotImplementedException();
        }

        public void EliminarGrupo(int idgrupo)
        {
            throw new NotImplementedException();
        }

        public void InsertarGrupo(Grupo grupo)
        {
            throw new NotImplementedException();
        }

        public List<Grupo> ListarGrupo()
        {
            throw new NotImplementedException();
        }
    }
}
