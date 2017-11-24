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
    public class MMaterias : IMaterias
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MMaterias()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarMaterias(Materias materias)
        {
            _db.Update(materias);
        }

        public Materias BuscarMaterias(int idmaterias)
        {
            return _db.Select<Materias>(x => x.IdMateria == idmaterias).FirstOrDefault();
        }

        public void EliminarMaterias(int materias)
        {
            _db.Delete<Materias>(x => x.IdMateria == materias);
        }

        public void InsertarMaterias(Materias materias)
        {
            _db.Insert(materias);
        }

        public List<Materias> ListarMaterias()
        {
            return _db.Select<Materias>();
        }
    }
}
