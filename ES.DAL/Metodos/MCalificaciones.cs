using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DAL.Interfaces;
using ES.DATA;
using ServiceStack.OrmLite;
using System.Data;


namespace ES.DAL.Metodos
{
   public class MCalificaciones : ICalificaciones
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MCalificaciones()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarCalificaciones(Calificaciones calificaciones)
        {
            _db.Update(calificaciones);
        }

        public Calificaciones BuscarCalificacionese(int idcalificaciones)
        {
            return _db.Select<Calificaciones>(x => x.IdCalificaciones == idcalificaciones)
                .FirstOrDefault();
        }

        public Calificaciones BuscarCalificacionesPorIdAlumnos(int idalumnos)
        {
            return _db.Select<Calificaciones>(x => x.idAlumno == idalumnos)
                .FirstOrDefault();
        }

        public Calificaciones BuscarCalificacionesPorIdMateria(int idmaterias)
        {
            return _db.Select<Calificaciones>(x => x.IdMateria == idmaterias)
                .FirstOrDefault();
        }

        public void EliminarCalificaciones(int idcalificaciones)
        {
            _db.Delete<Calificaciones>(x => x.IdCalificaciones == idcalificaciones);
        }

        public void InsertarCalificaciones(Calificaciones calificaciones)
        {
            _db.Insert(calificaciones);
        }

        public List<Calificaciones> ListarCalificaciones()
        {
            throw new NotImplementedException();
        }
    }
}
