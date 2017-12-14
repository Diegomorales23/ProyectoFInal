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
                res = _db.Select<TB_Estudiantes>().ToArray();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MEstudiantes -> GetEstudiantesInfo(). \nDescripción: " + ex.Message);
            }
            return res;
        }
        
        // GetCantEstudiantes()
        public int GetCantEstudiantes()
        {
            var res = 0;

            try
            {
                res = _db.Select<TB_Estudiantes>().Count;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MEstudiantes -> GetCantEstudiantes(). \nDescripción: " + ex.Message);
            }
            return res;
        }

        public void InsertarEstudiante(TB_Estudiantes Estudiante)
        {
            _db.Insert(Estudiante);
        }

        public void EliminarEstudiante(string IdEstudiante)
        {
            _db.Delete<TB_Estudiantes>(x => x.ID_ESTUDIANTE == IdEstudiante);
        }

        public TB_Estudiantes[] BuscarEstudiante(string IdEstudiante)
        {
            TB_Estudiantes[] res = { };

            try
            {
                res = _db.Select<TB_Estudiantes>(x => x.ID_ESTUDIANTE == IdEstudiante).ToArray();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MEstudiantes -> GetEstudiantesInfo(). \nDescripción: " + ex.Message);
            }
            return res;
        }

        public void ActualizarEstudiante(TB_Estudiantes Estudiante)
        {
            _db.Update(Estudiante);
        }

    }
}
