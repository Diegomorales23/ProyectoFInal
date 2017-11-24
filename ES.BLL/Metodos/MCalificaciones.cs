using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.BLL.Interfaces;
using ES.DATA;
namespace ES.BLL.Metodos
{
    public class MCalificaciones : ICalificaciones
    {
        private DAL.Interfaces.ICalificaciones calif;
        public MCalificaciones()
        {
            calif = new DAL.Metodos.MCalificaciones();
        }
        public void ActualizarCalificaciones(Calificaciones calificaciones)
        {
            calif.ActualizarCalificaciones(calificaciones);
        }

        public Calificaciones BuscarCalificacionese(int idcalificaciones)
        {
            return calif.BuscarCalificacionese(idcalificaciones);
        }

        public Calificaciones BuscarCalificacionesPorIdAlumnos(int idalumnos)
        {
            return calif.BuscarCalificacionesPorIdAlumnos(idalumnos);
        }

        public Calificaciones BuscarCalificacionesPorIdMateria(int idmaterias)
        {
            return calif.BuscarCalificacionesPorIdMateria(idmaterias);
        }

        public void EliminarCalificaciones(int idcalificaciones)
        {
            calif.EliminarCalificaciones(idcalificaciones);
        }

        public void InsertarCalificaciones(Calificaciones calificaciones)
        {
            calif.InsertarCalificaciones(calificaciones);
        }

        public List<Calificaciones> ListarCalificaciones()
        {
            throw new NotImplementedException();
        }
    }
}
