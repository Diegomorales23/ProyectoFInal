using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Data;
using ES.DATA;
namespace ES.DAL.Metodos
{/*
    public class Mroles : IRoles
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public Mroles()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarRoles(Roles roles)
        {
            _db.Update(roles);
        }
        /*
        public Roles BuscarRoles(int idRoles)
        {
            return _db.Select<Roles>(x => x.IdRol == idRoles).FirstOrDefault();
        }

        public Roles BuscarRolesNombre(string roles)
        {
            return _db.Select<Roles>(x => x.Rol==roles).FirstOrDefault();
        }

        public void EliminarRoles(int idroles)
        {
            _db.Delete<Roles>(x => x.IdRol == idroles);
        }

        public void InsertarRoles(Roles roles)
        {
            _db.Insert(roles);
        }

        public List<Roles> ListarRoles()
        {
            throw new NotImplementedException();
        }
        }*/
}
