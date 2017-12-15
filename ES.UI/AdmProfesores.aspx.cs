using ES.BLL.Interfaces;
using ES.BLL.Metodos;
using ES.DATA;
using System;
using System.Web.Services;

namespace ES.UI
{
    public partial class AdmProfesores : System.Web.UI.Page
    {
        static IProfesores _profe;
        static IHerramientas _herra;

        public AdmProfesores()
        {
            _profe = new MProfesores();
            _herra = new MHerramientas();
        }

        protected void Page_Load(object sender, EventArgs e) { }

        protected void MostrarProfesores()
        {
            var res = _profe.GetInfo();
            for (int i = 0; i < _profe.GetCant(); i++)
            {
                var table = string.Format("<tr> <td>{0}</td> <td>{1}</td> <td>{2}</td> <td>{3}</td> <td></td> </tr>", _herra.Decrypt(res[i].ID_PROFESOR), _herra.CapitalizeByWord(_herra.Decrypt(res[i].NOMBRE) + " " + _herra.Decrypt(res[i].APELLIDOS)), _herra.Decrypt(res[i].EMAIL).ToLower(), _herra.Decrypt(res[i].TELEFONO));
                Response.Write(table);
            }
        }

        [WebMethod]
        public static void Insertar(string P_Cedula, string P_Nombre, string P_Apellidos, string P_Telefono, string P_Email, string P_Padecimientos, string P_Direccion)
        {
            var Profesor = new TB_Profesores
            {
                ID_PROFESOR = _herra.Encrypt(P_Cedula),
                NOMBRE = _herra.Encrypt(P_Nombre.ToUpper()),
                APELLIDOS = _herra.Encrypt(P_Apellidos.ToUpper()),
                TELEFONO = _herra.Encrypt(P_Telefono),
                EMAIL = _herra.Encrypt(P_Email.ToUpper()),
                PADECIMIENTOS = _herra.Encrypt(P_Padecimientos.ToUpper()),
                DIRECCION = _herra.Encrypt(P_Direccion.ToUpper())
            };

            _profe.Insertar(Profesor);
        }

        [WebMethod]
        public static void Eliminar(string Id)
        {
            Id = _herra.Encrypt(Id);
            _profe.Eliminar(Id);
        }

        [WebMethod]
        public static TB_Profesores[] GetInfo(string Id)
        {
            Id = _herra.Encrypt(Id);
            var res = _profe.Buscar(Id);

            res[0].ID_PROFESOR = _herra.Decrypt(res[0].ID_PROFESOR);
            res[0].NOMBRE = _herra.CapitalizeByWord(_herra.Decrypt(res[0].NOMBRE));
            res[0].APELLIDOS = _herra.CapitalizeByWord(_herra.Decrypt(res[0].APELLIDOS));
            res[0].TELEFONO = _herra.Decrypt(res[0].TELEFONO);
            res[0].EMAIL = _herra.Decrypt(res[0].EMAIL).ToLower();
            res[0].PADECIMIENTOS = _herra.Capitalize(_herra.Decrypt(res[0].PADECIMIENTOS));
            res[0].DIRECCION = _herra.Capitalize(_herra.Decrypt(res[0].DIRECCION));

            return res;
        }

        [WebMethod]
        public static void Actualizar(string P_Cedula, string P_Nombre, string P_Apellidos, string P_Telefono, string P_Email, string P_Padecimientos, string P_Direccion)
        {
            var Profesor = new TB_Profesores
            {
                ID_PROFESOR = _herra.Encrypt(P_Cedula),
                NOMBRE = _herra.Encrypt(P_Nombre.ToUpper()),
                APELLIDOS = _herra.Encrypt(P_Apellidos.ToUpper()),
                TELEFONO = _herra.Encrypt(P_Telefono),
                EMAIL = _herra.Encrypt(P_Email.ToUpper()),
                PADECIMIENTOS = _herra.Encrypt(P_Padecimientos.ToUpper()),
                DIRECCION = _herra.Encrypt(P_Direccion.ToUpper())
            };

            _profe.Actualizar(Profesor);
        }
    }
}