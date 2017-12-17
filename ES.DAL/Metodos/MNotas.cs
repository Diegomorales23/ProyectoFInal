using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DAL.Interfaces;
using ES.DATA;
using ServiceStack.OrmLite;
using System.Data;
using System.Diagnostics;

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

        // GetInfo()
        public List<tempNotas> GetInfo()
        {
            return _db.SqlList<tempNotas>("EXEC SP_GETNOTAS");
        }

        public List<tempNotas_> GetInfoById(string Id)
        {
            var SQL = string.Format("EXEC SP_GETNOTASBYEST '{0}'",Id);
            return _db.SqlList<tempNotas_>(SQL);
        }

        public void Actualizar(string Id, string IP, string IIP, string IIIP)
        {
            Debug.WriteLine(Id);
            Debug.WriteLine(IP);
            Debug.WriteLine(IIP);
            Debug.WriteLine(IIIP);
            var SQL = string.Format("EXEC SP_GETUPDATENOTAS {0},{1},{2},{3}", Convert.ToInt32(Id), Convert.ToInt32(IP), Convert.ToInt32(IIP), Convert.ToInt32(IIIP));
            _db.ExecuteSql(SQL);
        }



    }
}
