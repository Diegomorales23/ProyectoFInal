﻿using ES.DAL.Interfaces;
using ES.DATA;
using ServiceStack.OrmLite;
using System;
using System.Data;
using System.Diagnostics;

namespace ES.DAL.Metodos
{
    public class MProfesores : IProfesores
    {
        OrmLiteConnectionFactory _conexion;
        IDbConnection _db;
        IHerramientas _herra;

        public MProfesores()
        {
            _herra = new MHerramientas();
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        // GetInfo()
        public TB_Profesores[] GetInfo()
        {
            TB_Profesores[] res = { };

            try
            {
                res = _db.Select<TB_Profesores>().ToArray();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MProfesores -> GetInfo(). \nDescripción: " + ex.Message);
            }
            return res;
        }

        // GetCant()
        public int GetCant()
        {
            var res = 0;

            try
            {
                res = _db.Select<TB_Profesores>().Count;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MProfesores -> GetCant(). \nDescripción: " + ex.Message);
            }
            return res;
        }

        // Insertar()
        public void Insertar(TB_Profesores Profesor)
        {
            _db.Insert(Profesor);
        }

        // Eliminar()
        public void Eliminar(string Id)
        {
            _db.Delete<TB_Profesores>(x => x.ID_PROFESOR == Id);
        }

        // Buscar()
        public TB_Profesores[] Buscar(string Id)
        {
            TB_Profesores[] res = { };

            try
            {
                res = _db.Select<TB_Profesores>(x => x.ID_PROFESOR == Id).ToArray();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\nError \nUbicación: Capa DAL -> MProfesores -> Buscar(). \nDescripción: " + ex.Message);
            }
            return res;
        }

        // Actualizar()
        public void Actualizar(TB_Profesores Profesor)
        {
            _db.Update(Profesor);
        }
    }
}
