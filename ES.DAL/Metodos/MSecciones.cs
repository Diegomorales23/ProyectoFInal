using ES.DAL.Interfaces;
using ES.DATA;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DAL.Metodos
{
    public class MSecciones : ISecciones
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        IHerramientas herra;

        public MSecciones()
        {
            herra = new MHerramientas();
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        // GetInfo()
        public TB_Secciones[] GetInfo()
        {
            TB_Secciones[] res = { };

            try
            {
                res = _db.Select<TB_Secciones>().ToArray();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MSecciones -> GetInfo(). \nDescripción: " + ex.Message);
            }
            return res;
        }
    }
}
