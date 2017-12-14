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

    public class MAlumnos : IAlumnos
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MAlumnos()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarAlumnos(Alumnos alumnos)
        {
            _db.Update(alumnos);
        }

        public Alumnos BuscarAlumnos(string cedula)
        {
            return _db.Select<Alumnos>(x => x.Cedula == cedula)
               .FirstOrDefault();
        }

        public void EliminarAlumnos(string cedula)
        {
            _db.Delete<Alumnos>(x => x.Cedula == cedula);
        }


        public bool ExisteAlumno(string cedula)
        {
            try
            {
                Alumnos Alu = _db.Select<Alumnos>(x => x.Cedula == cedula).FirstOrDefault();

                if (Alu.Cedula == cedula)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex)
            {

                if (ex.Message == "Referencia a objeto no establecida como instancia de un objeto.")
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }

        public void InsertarAlumnos(Alumnos alumnos)
        {
            _db.Insert(alumnos);
        }

        public List<Alumnos> ListaAlumnos()
        {
            return _db.Select<Alumnos>();
        }

        public List<Alumnos> ListarAlumnos(int idCalificaciones)
        {
            throw new NotImplementedException();
        }

        public List<Alumnos> ListarAlumnos(string idAlumnos)
        {
            return _db.Select<Alumnos>(x => x.Cedula == idAlumnos);
        }
    }

}
