using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.BLL.Interfaces;
using ES.DATA;
namespace ES.BLL.Metodos
{
    public class MGrupo_Alumnos : IGrupo_Alumnos
    {
        private DAL.Interfaces.IGrupo_Alumnos ga;
        public MGrupo_Alumnos()
        {
            ga = new DAL.Metodos.MGrupo_Alumnos();
        }
        public void ActualizarGrupo_Alumnos(Grupo_Alumnos grupo_alumnos)
        {
            ga.ActualizarGrupo_Alumnos(grupo_alumnos);
        }

        public Grupo_Alumnos BuscarGrupo_Alumnos(int idgrupo)
        {
            return ga.BuscarGrupo_Alumnos(idgrupo);
        }

        public void EliminarGrupo_Alumnos(int idgrupo)
        {
            ga.EliminarGrupo_Alumnos(idgrupo);
        }

        public void InsertarGrupo_Alumnos(Grupo_Alumnos grupo_alumnos)
        {
            ga.InsertarGrupo_Alumnos(grupo_alumnos);
        }

        public List<Grupo_Alumnos> ListaGrupo_Alumnos()
        {
            throw new NotImplementedException();
        }
    }
}
