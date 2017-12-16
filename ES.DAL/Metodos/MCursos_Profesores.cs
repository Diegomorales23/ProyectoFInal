using ES.DAL.Interfaces;
using ES.DAL.Metodos;
using ES.DATA;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DAL.Metodos
{
    public class MCursos_Profesores : ICursos_Profesores
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        private IHerramientas _herra;

        public MCursos_Profesores()
        {
            _herra = new MHerramientas();
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        // Insertar()
        public void Insertar(TB_Cursos_Profesores NuevaRel)
        {
            _db.Insert(NuevaRel);
        }

        // Eliminar()
        public void Eliminar(int Id)
        {
            _db.Delete<TB_Cursos_Profesores>(x => x.ID_C == Id);
        }
    }
}
