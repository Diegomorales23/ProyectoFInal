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
   public class MNotas : INotas
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MNotas()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void CrearNotasEst(TB_Notas Notas)
        {
            _db.Insert(Notas);
        }
    }
}
