using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.BLL.Interfaces;
using ES.DATA;
namespace ES.BLL.Metodos
{
    public class MGrupo_Profesor : IGrupo_Profesor
    {
        private DAL.Interfaces.IGrupo_Profesor gp;
        public MGrupo_Profesor()
        {
            gp = new DAL.Metodos.MGrupo_Profesor();
        }
        public void ActualizarGrupo_Profesor(Grupo_Profesor grupo_profesor)
        {
            gp.ActualizarGrupo_Profesor(grupo_profesor);
        }

        public Grupo_Profesor BuscarGrupo_Profesor(int idgrupo)
        {
            return gp.BuscarGrupo_Profesor(idgrupo);
        }

        public void EliminarGrupo_Profesor(int idgrupo)
        {
            gp.EliminarGrupo_Profesor(idgrupo);
        }

        public void InsertarGrupo_Profesor(Grupo_Profesor grupo_profesor)
        {
            gp.InsertarGrupo_Profesor(grupo_profesor);
        }

        public List<Grupo_Profesor> ListaGrupo_Profesor()
        {
            throw new NotImplementedException();
        }
    }
}
