using ES.BLL.Interfaces;
using ES.BLL.Metodos;
using ES.DATA;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ES.UI
{
    public partial class AdmEstudiantes : System.Web.UI.Page
    {
        private static IEstudiantes _est;
        private static IEncargado _enc;
        private static IParentesco _par;
        private static INotas _cal;

        private static IHerramientas _herra;

        public AdmEstudiantes()
        {
            _est = new MEstudiantes();
            _enc = new MEncargado();
            _herra = new MHerramientas();
            _par = new MParentesco();
            _cal = new MNotas();
        }

        protected void Page_Load(object sender, EventArgs e) { }

        protected void MostrarEstudiantes()
        {
            var res = _est.GetEstudiantesInfo();
            for (int i = 0; i < _est.GetCantEstudiantes(); i++)
            {
                var table = string.Format("<tr> <td>{0}</td> <td>{1}</td> <td>{2}</td> <td>{3}</td> <td></td> </tr>", res[i].ID_ESTUDIANTE, _herra.CapitalizeByWord(_herra.Decrypt(res[i].NOMBRE) + " " + _herra.Decrypt(res[i].APELLIDOS)), _herra.Decrypt(res[i].SECCION), _herra.Decrypt(res[i].TELEFONO));
                Response.Write(table);
            }
        }

        [WebMethod]
        public static void IngresarEstudiante(string E_Cedula, string E_Nombre, string E_Apellidos, string E_Telefono, string E_Email, string E_Direccion, string E_Padecimientos, string E_Grado, string E_Adelanta, string E_GradoAdelanta, string EN_Cedula, string EN_Nombre, string EN_Apellidos, string EN_TelRes, string EN_TelTra, string EN_TelMov, string EN_Parentesco, string EN_LugarTra, string EN_Ocupacion)
        {

            var ID_Parentesco = _par.GetIdParentesco(EN_Parentesco.ToUpper());

            var Encargado = new TB_Encargados
            {
                ID_ENCARGADO = EN_Cedula,
                NOMBRE = _herra.Encrypt(EN_Nombre),
                APELLIDOS = _herra.Encrypt(EN_Apellidos),
                TEL_RESIDENCIA = _herra.Encrypt(EN_TelRes),
                TEL_TRABAJO = _herra.Encrypt(EN_TelTra),
                TEL_MOVIL = _herra.Encrypt(EN_TelMov),
                ID_PARENTESCO = ID_Parentesco,
                LUGAR_TRABAJO = _herra.Encrypt(EN_LugarTra),
                OCUPACION = _herra.Encrypt(EN_Ocupacion),
            };

            _enc.InsertarEncargado(Encargado);

            for (int i = 0; i < 15; i++)
            {
                var Notas = new TB_Notas
                {
                    ID_ESTUDIANTE = E_Cedula,
                    ID_MATERIA = i.ToString(),
                    PRIMER_PERIODO = 0,
                    SEGUNDO_PERIODO = 0,
                    TERCER_PERIODO = 0,
                    CONVOCATORIA_I = 0,
                    CONVOCATORIA_II = 0,
                    CONVOCATORIA_III = 0,
                    PROMEDIO = 0
                };

                _cal.CrearNotasEst(Notas);
            }

            var Adelanta = false;
            if (E_Adelanta == "Si")
            {
                Adelanta = true;
            }
            else
            {
                Adelanta = false;
            }

            var Estudiante = new TB_Estudiantes
            {
                ID_ESTUDIANTE = E_Cedula,
                ID_ENCARGADO = EN_Cedula,
                NOMBRE = _herra.Encrypt(E_Nombre),
                APELLIDOS = _herra.Encrypt(E_Apellidos),
                TELEFONO = _herra.Encrypt(E_Telefono),
                EMAIL = _herra.Encrypt(E_Email),
                PADECIMIENTOS = _herra.Encrypt(E_Padecimientos),
                DIRECCION = _herra.Encrypt(E_Direccion),
                GRADUADO = false,
                ABANDONO = false,
                ANO_GRADUACION = "null",
                ID_NIVEL = "1",
                SECCION = _herra.Encrypt("7-1"),
                ADELANTA = Adelanta,
                NIVEL_ADELANTA = _herra.Encrypt(E_GradoAdelanta)
            };

            _est.InsertarEstudiante(Estudiante);
        }

        [WebMethod]
        public static void EliminarEstudiante(string IdEstudiante)
        {
            _est.EliminarEstudiante(IdEstudiante);
        }

        [WebMethod]
        public static TB_Estudiantes[] GetInfoEstudiante(string IdEstudiante)
        {
            var res = _est.BuscarEstudiante(IdEstudiante);
            res[0].NOMBRE = _herra.CapitalizeByWord(_herra.Decrypt(res[0].NOMBRE));
            res[0].APELLIDOS = _herra.CapitalizeByWord(_herra.Decrypt(res[0].APELLIDOS));
            res[0].TELEFONO = _herra.Decrypt(res[0].TELEFONO);
            res[0].EMAIL = _herra.Decrypt(res[0].EMAIL).ToLower();
            res[0].PADECIMIENTOS = _herra.Capitalize(_herra.Decrypt(res[0].PADECIMIENTOS));
            res[0].DIRECCION = _herra.Capitalize(_herra.Decrypt(res[0].DIRECCION));

            return res;
        }

        [WebMethod]
        public static void ActualizarEstudiante(string Cedula, string Nombre, string Apellidos, string Telefono, string Email, string Graduado, string Abandono, string AnoGraduacion, string Grado, string Seccion, string Adelanta, string Padecimientos, string Direccion)
        {
            var Graduado_ = false;
            var Abandono_ = false;
            var Adelanta_ = false;

            if (Graduado == "true")
            {
                Graduado_ = true;
            }

            if (Abandono == "true")
            {
                Abandono_ = true;
            }

            if (Adelanta == "true")
            {
                Adelanta_ = true;
            }

            var Estudiante = new TB_Estudiantes
            {
                ID_ENCARGADO = "112345678",
                ID_ESTUDIANTE = Cedula,
                NOMBRE = Nombre,
                APELLIDOS = Apellidos,
                TELEFONO = Telefono,
                EMAIL = Email,
                GRADUADO = Graduado_,
                ABANDONO = Abandono_,
                ANO_GRADUACION = AnoGraduacion,
                ID_NIVEL = Grado,
                SECCION = Seccion,
                ADELANTA = Adelanta_,
                PADECIMIENTOS = Padecimientos,
                DIRECCION = Direccion
            }; 

            _est.ActualizarEstudiante(Estudiante);
        }
    }
}