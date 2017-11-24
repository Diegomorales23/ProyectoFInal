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
        public void ActualizarProfesor(Profesor profesor)
        {
            profe.ActualizarProfesor(profesor);
        }

        public void EliminarProfesor(int idProfesor)
        {
            profe.EliminarProfesor(idProfesor);
        }

        public void InsertarProfesor(Profesor profesor)
        {
            profe.InsertarProfesor(profesor);
        }

        public List<Profesor> ListaProfesor()
        {
            return profe.ListaProfesor();
        }

        Profesor IProfesor.BuscarProfesor(int idProfesor)
        {
            return profe.BuscarProfesor(idProfesor);
        }
    }
}
