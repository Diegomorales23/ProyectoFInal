﻿using ES.DAL.Interfaces;
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
        IHerramientas herra;

        public MParentesco()
        {
            herra = new MHerramientas();
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        
        // GetInfo()
        public TB_Parentesco[] GetInfo()
        {
            TB_Parentesco[] res = { };

            try
            {
                res = _db.Select<TB_Parentesco>().ToArray();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MParentesco -> GetInfo(). \nDescripción: " + ex.Message);
            }
            return res;
        }
    }
}
