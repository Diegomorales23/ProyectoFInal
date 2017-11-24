using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.BLL.Interfaces;
using ES.DATA;
namespace ES.BLL.Metodos
{
    public class MMaterias : IMaterias
    {
        private DAL.Interfaces.IMaterias mate;
        public MMaterias()
        {
            mate = new DAL.Metodos.MMaterias();
        }

        public void ActualizarMaterias(Materias materias)
        {
            mate.ActualizarMaterias(materias);
        }

        public Materias BuscarMaterias(int idmaterias)
        {
            return mate.BuscarMaterias(idmaterias);
        }

        public void EliminarMaterias(int materias)
        {
            mate.EliminarMaterias(materias);
        }

        public void InsertarMaterias(Materias materias)
        {
            mate.InsertarMaterias(materias);
        }

        public List<Materias> ListarMaterias()
        {
           return mate.ListarMaterias();
        }
    }
}
