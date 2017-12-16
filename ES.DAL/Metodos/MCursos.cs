using ES.DAL.Interfaces;
using ES.DATA;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DAL.Metodos
{
    public class MCursos : ICursos
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        private IHerramientas _herra;

        public MCursos()
        {
            _herra = new MHerramientas();
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        // Insertar()
        public void Insertar(TB_Cursos NuevoCurso)
        {
            _db.Insert(NuevoCurso);
        }

        // GetCant()
        public int GetCant()
        {
            var res = 0;

            try
            {
                res = _db.Select<TB_Cursos>().Count;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MCursos -> GetCant(). \nDescripción: " + ex.Message);
            }
            return res;
        }

        // GetInfo()
        public List<tempCursos> GetInfo()
        {
            return _db.SqlList<tempCursos>("EXEC SP_GETCURSOS");
        }

        // Eliminar()
        public void Eliminar(int Id)
        {
            _db.Delete<TB_Cursos>(x => x.ID_CUR == Id);
        }
    }
}
