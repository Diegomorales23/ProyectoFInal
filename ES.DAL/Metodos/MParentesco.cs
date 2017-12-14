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
    public class MParentesco : IParentesco
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        private IHerramientas _herra;

        public MParentesco()
        {
            _herra = new MHerramientas();
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        // GetIdParentesco()
        public string GetIdParentesco(string Parentesco)
        {
            Debug.WriteLine(Parentesco);
            var res = string.Empty;
            TB_Parentesco[] res_ = { };

            try
            {
                res_ = _db.Select<TB_Parentesco>(x => x.NOMBRE == Parentesco).ToArray();
                Debug.WriteLine(res_[0].ID_PARENTESCO);
                res = res_[0].ID_PARENTESCO;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MParentesco -> GetIdParentesco(). \nDescripción: " + ex.Message);
            }
            return res;
        }
    }
}
