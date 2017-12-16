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
    public class MEncargado : IEncargado
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MEncargado()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void Insertar(TB_Encargados Encargado)
        {
            _db.Insert(Encargado);
        }

        public void Eliminar(string Id)
        {
            _db.Delete<TB_Encargados>(x => x.ID_ENCARGADO == Id);
        }
    }
}
