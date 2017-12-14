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
        public void ActualizarProfesor(TB_PROFESOR profesor)
        {
            _db.Update(profesor);
        }

        public TB_PROFESOR BuscarProfesor(int idProfesor)
        {
           return _db.Select<TB_PROFESOR>(x => x.Id_Profesor == idProfesor).FirstOrDefault();
        }

        public void EliminarProfesor(int idProfesor)
        {
            _db.Delete<TB_PROFESOR>(x => x.Id_Profesor == idProfesor);
        }

        public void InsertarProfesor(TB_PROFESOR profesor)
        {
            _db.Insert(profesor);
        }

        public List<TB_PROFESOR> ListaProfesor()
        {
            return _db.Select<TB_PROFESOR>();
        }
    }
}
