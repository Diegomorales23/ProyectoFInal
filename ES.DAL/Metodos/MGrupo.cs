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
    public class MGrupo : IGrupo
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MGrupo()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarGrupo(Grupo grupo)
        {
            _db.Update(grupo);
        }

        public Grupo BuscarGrupo(int idgrupo)
        {
            return _db.Select<Grupo>(x => x.IdGrupo == idgrupo)
                 .FirstOrDefault();
        }

        public Grupo BuscarGrupoNombre(string grupo)
        {
            throw new NotImplementedException();
        }

        public void EliminarGrupo(int idgrupo)
        {
            _db.Delete<Grupo>(x => x.IdGrupo == idgrupo);
        }

        public void InsertarGrupo(Grupo grupo)
        {
            _db.Insert(grupo);
        }

        public List<Grupo> ListarGrupo()
        {
            throw new NotImplementedException();
        }
    }
}
