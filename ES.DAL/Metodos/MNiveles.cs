using ES.DAL.Interfaces;
using ES.DATA;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace ES.DAL.Metodos
{
    public class MNiveles : INiveles
    {
        OrmLiteConnectionFactory _conexion;
        IDbConnection _db;

        public MNiveles()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        // GetInfo()
        public TB_Niveles[] GetInfo()
        {
            TB_Niveles[] res = { };

            try
            {
                res = _db.Select<TB_Niveles>().ToArray();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MNiveles -> GetInfo(). \nDescripción: " + ex.Message);
            }
            return res;
        }








        // ListarNiveles();
        public List<TB_Niveles> ListarNiveles()
        {
            return _db.Select<TB_Niveles>();
        }

        // GetId()
        public int GetId(string NOMBRE)
        {
            TB_Niveles[] res_ = { };
            var res = 0;

            try
            {
                res_ = _db.Select<TB_Niveles>(x => x.NOMBRE == NOMBRE).ToArray();
                res = res_[0].ID_NIVEL;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MNiveles -> GetId(). \nDescripción: " + ex.Message);
            }
            return res;
        }
    }
}
