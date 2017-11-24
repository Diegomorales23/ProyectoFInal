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
    
    public class MGrupo_Alumnos : IGrupo_Alumnos
    {
        private OrmLiteConnectionFactory _conexion;
    private IDbConnection _db;

    public MGrupo_Alumnos()
    {
        _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
        _db = _conexion.Open();
    }
        public void ActualizarGrupo_Alumnos(Grupo_Alumnos grupo_alumnos)
        {
            _db.Update(grupo_alumnos);
        }

        public Grupo_Alumnos BuscarGrupo_Alumnos(int idgrupo)
        {
            return _db.Select<Grupo_Alumnos>(x => x.IdGrupo == idgrupo)
                .FirstOrDefault();
        }

        public void EliminarGrupo_Alumnos(int idgrupo)
        {
            _db.Delete<Grupo_Alumnos>(x => x.IdGrupo == idgrupo);
        }

        public void InsertarGrupo_Alumnos(Grupo_Alumnos grupo_alumnos)
        {
            _db.Insert(grupo_alumnos);
        }

        public List<Grupo_Alumnos> ListaGrupo_Alumnos()
        {
            throw new NotImplementedException();
        }
    }
}
