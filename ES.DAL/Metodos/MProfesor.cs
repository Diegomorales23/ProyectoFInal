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
    public class MProfesor : IProfesor
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MProfesor()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarProfesor(Profesor profesor)
        {
            _db.Update(profesor);
        }

        public Profesor BuscarProfesor(int idProfesor)
        {
           return _db.Select<Profesor>(x => x.IdProfesor == idProfesor).FirstOrDefault();
        }

        public void EliminarProfesor(int idProfesor)
        {
            _db.Delete<Profesor>(x => x.IdProfesor == idProfesor);
        }

        public void InsertarProfesor(Profesor profesor)
        {
            _db.Insert(profesor);
        }

        public List<Profesor> ListaProfesor()
        {
            throw new NotImplementedException();
        }
    }
}
