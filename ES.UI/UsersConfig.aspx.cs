using ES.BLL.Interfaces;
using ES.BLL.Metodos;
using ES.DATA;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Services;

namespace ES.UI
{
    public partial class UsersConfig : System.Web.UI.Page
    {
        private static IUsuarios _usu;
        private static IHerramientas _herra;

        public UsersConfig()
        {
            _usu = new MUsuarios();
            _herra = new MHerramientas();
        }

        protected void Page_Load(object sender, EventArgs e) { }

        protected void MostrarUsuarios()
        {
            var res = _usu.ObtenerInfoGeneral();

            for (int i = 0; i < _usu.TotalUsuarios(); i++)
            {
                Response.Write("<tr>" +
                                 "<td class='text-center'>" + _herra.Decrypt(res[i].USUARIO) + "</td>" +
                                 "<td class='text-center'>" + _herra.CapitalizeByWord(_herra.Decrypt(res[i].NOMBRE) + " " + _herra.Decrypt(res[i].APELLIDOS)) + "</td>" +
                                 "<td class='text-center'>" + _herra.CapitalizeByWord(_usu.ObtenerRol(res[i].ID_ROL)) + "</td>" +
                                 "<td class='text-center'>" + _herra.Decrypt(res[i].EMAIL).ToLower() + "</td>" +
                                 "<td class='text-center'>" + _herra.Decrypt(res[i].TELEFONO) + "</td>" +
                                 "<td></td>" +
                               "</tr>");
            }
        }

        [WebMethod]
        public static List<string> VerUsuario(string Usuario)
        {
            Usuario = _herra.Encrypt(Usuario);
            var res = _usu.ObtenerInfo(Usuario);

            List<string> res_ = new List<string>();

            res_.Add(_herra.CapitalizeByWord(_herra.Decrypt(res[0].NOMBRE)));
            res_.Add(_herra.CapitalizeByWord(_herra.Decrypt(res[0].APELLIDOS)));
            res_.Add(_herra.Decrypt(res[0].EMAIL).ToLower());
            res_.Add(_herra.Decrypt(res[0].CEDULA));
            res_.Add(_herra.Capitalize(_usu.ObtenerRol(res[0].ID_ROL)));
            res_.Add(_herra.Decrypt(res[0].TELEFONO));
            res_.Add(_herra.Decrypt(res[0].FOTO));

            return res_;
        }

        [WebMethod]
        public static void CrearUsuario(string Nombre, string Apellidos, string Email, string Cedula, string Rol, string Telefono)
        {
            _usu.Obtener_IdRol("");
        }

        [WebMethod]
        public static bool EliminarUsuario(string Usuario)
        {
            var res = false;

            if (_usu.TotalUsuarios() == 1)
            {
                res = false;
            }
            else
            {
                Usuario = _herra.Encrypt(Usuario);
                _usu.EliminarUsuario(Usuario);

                res = true;
            }
            return res;
        }
    }
}