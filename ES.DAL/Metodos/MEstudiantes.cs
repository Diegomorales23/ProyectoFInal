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
        IHerramientas herra;

        public MEstudiantes()
        {
            herra = new MHerramientas();
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        // GetInfo()
        public TB_Estudiantes[] GetInfo()
        {
            TB_Estudiantes[] res = { };

            try
            {
                res = _db.Select<TB_Estudiantes>().ToArray();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MEstudiantes -> GetInfo(). \nDescripción: " + ex.Message);
            }
            return res;
        }
        
        // GetCant()
        public int GetCant()
        {
            var res = 0;

            try
            {
                res = _db.Select<TB_Estudiantes>().Count;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MEstudiantes -> GetCant(). \nDescripción: " + ex.Message);
            }
            return res;
        }
        
        // Insertar()
        public void Insertar(TB_Estudiantes Estudiante)
        {
            _db.Insert(Estudiante);
        }

        // Eliminar()
        public void Eliminar(string Id)
        {
            _db.Delete<TB_Estudiantes>(x => x.ID_ESTUDIANTE == Id);
        }

        // Buscar()
        public TB_Estudiantes[] Buscar(string Id)
        {
            TB_Estudiantes[] res = { };

            try
            {
                res = _db.Select<TB_Estudiantes>(x => x.ID_ESTUDIANTE == Id).ToArray();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MEstudiantes -> Buscar(). \nDescripción: " + ex.Message);
            }
            return res;
        }

        // Actualizar()
        public void Actualizar(TB_Estudiantes Estudiante)
        {
            _db.Update(Estudiante);
        }       
    }
}
