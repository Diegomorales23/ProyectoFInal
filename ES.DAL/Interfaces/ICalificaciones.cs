using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;

namespace ES.DAL.Interfaces
{
  public interface ICalificaciones
    {
        List<Calificaciones> ListarCalificaciones();
        Calificaciones BuscarCalificacionese(int idcalificaciones);
        Calificaciones BuscarCalificacionesPorIdAlumnos(int idalumnos);
        Calificaciones BuscarCalificacionesPorIdMateria(int idmaterias);

        //INSERT
        void InsertarCalificaciones(Calificaciones calificaciones);
        //UPDATE
        void ActualizarCalificaciones(Calificaciones calificaciones);
        //DELETE
        void EliminarCalificaciones(int idcalificaciones);

    }
}
