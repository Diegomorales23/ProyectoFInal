using System.Collections.Generic;
using ES.DAL.Interfaces;
using ES.DATA;
using ServiceStack.OrmLite;
using System.Data;
using System;
using System.Diagnostics;

namespace ES.DAL.Metodos
{
    public class MMaterias : IMaterias
    {
        OrmLiteConnectionFactory _conexion;
        IDbConnection _db;

        public MMaterias()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        // ListarMaterias();
        public List<TB_Materias> ListarMaterias()
        {
            return _db.Select<TB_Materias>();
        }

        // GetId()
        public int GetId(string NOMBRE)
        {
            TB_Materias[] res_ = { };
            var res = 0;

            try
            {
                res_ = _db.Select<TB_Materias>(x => x.NOMBRE == NOMBRE).ToArray();
                res = res_[0].ID_MATERIA;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MMaterias -> GetId(). \nDescripción: " + ex.Message);
            }
            return res;
        }
    }
}
