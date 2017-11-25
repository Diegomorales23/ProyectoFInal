using ES.DAL.Interfaces;
using ES.DATA;
using ServiceStack.OrmLite;
using System;
using System.Data;
using System.Diagnostics;

namespace ES.DAL.Metodos
{
    public class MEstudiantes : IEstudiantes
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        private IHerramientas _herra;

        public MEstudiantes()
        {
            _herra = new MHerramientas();
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        // GetEstudiantesInfo()
        public TB_Estudiantes[] GetEstudiantesInfo()
        {
            TB_Estudiantes[] res = { };

            try
            {
                //var q = _db.From<TB_Estudiantes>().Join<TB_Niveles>().Join<TB_Notas>();

                res = _db.Select<TB_Estudiantes>().ToArray();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MEstudiantes -> GetEstudiantesInfo(). \nDescripción: " + ex.Message);
            }
            return res;
        }
    }
}
