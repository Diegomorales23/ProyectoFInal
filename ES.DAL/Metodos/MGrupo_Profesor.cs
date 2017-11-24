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
    public class MGrupo_Profesor : IGrupo_Profesor
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MGrupo_Profesor()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarGrupo_Profesor(Grupo_Profesor grupo_profesor)
        {
            _db.Update(grupo_profesor);
        }

        public Grupo_Profesor BuscarGrupo_Profesor(int idgrupo)
        {
            return _db.Select<Grupo_Profesor>(x => x.IdGrupo ==idgrupo)
               .FirstOrDefault();
        }
    

        public void EliminarGrupo_Profesor(int idgrupo)
        {
            _db.Delete<Grupo_Profesor>(x => x.IdGrupo == idgrupo);
        }

        public void InsertarGrupo_Profesor(Grupo_Profesor grupo_profesor)
        {
            _db.Insert(grupo_profesor);
        }

        public List<Grupo_Profesor> ListaGrupo_Profesor()
        {
            throw new NotImplementedException();
        }
    }
}
