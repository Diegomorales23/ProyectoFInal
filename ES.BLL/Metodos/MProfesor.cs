using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.BLL.Interfaces;
using ES.DATA;
namespace ES.BLL.Metodos
{
    public class MProfesor : IProfesor
    {
        private DAL.Interfaces.IProfesor profe;
        public MProfesor()
        {
            profe = new DAL.Metodos.MProfesor();
        }
        public void ActualizarProfesor(TB_PROFESOR profesor)
        {
            profe.ActualizarProfesor(profesor);
        }

        public void EliminarProfesor(int idProfesor)
        {
            profe.EliminarProfesor(idProfesor);
        }

        public void InsertarProfesor(TB_PROFESOR profesor)
        {
            profe.InsertarProfesor(profesor);
        }

        public List<TB_PROFESOR> ListaProfesor()
        {
            return profe.ListaProfesor();
        }

        TB_PROFESOR IProfesor.BuscarProfesor(int idProfesor)
        {
            return profe.BuscarProfesor(idProfesor);
        }
    }
}
