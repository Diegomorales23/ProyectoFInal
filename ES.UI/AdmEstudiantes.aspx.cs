using ES.BLL.Interfaces;
using ES.BLL.Metodos;
using ES.DATA;
using System;
using System.Diagnostics;
using System.Web.Services;

namespace ES.UI
{
    public partial class AdmEstudiantes : System.Web.UI.Page
    {
        static IEstudiantes est;
        static IEncargado enc;
        static IParentesco par;
        static INotas cal;
        static IHerramientas herra;
        static ISecciones sec;
        static INiveles niv;
        static ICursos cur;

        public AdmEstudiantes()
        {
            est = new MEstudiantes();
            enc = new MEncargado();
            herra = new MHerramientas();
            par = new MParentesco();
            cal = new MNotas();
            sec = new MSecciones();
            niv = new MNiveles();
            cur = new MCursos();
        }

        protected void Page_Load(object sender, EventArgs e) { }

        protected void MostrarEstudiantes()
        {
            var res = est.GetInfo();
            for (int i = 0; i < est.GetCant(); i++)
            {
                var table = string.Format("<tr> <td>{0}</td> <td>{1}</td> <td>{2}</td> <td>{3}</td> <td></td> </tr>", herra.Decrypt(res[i].ID_ESTUDIANTE), herra.CapitalizeByWord(herra.Decrypt(res[i].NOMBRE) + " " + herra.Decrypt(res[i].APELLIDOS)), res[i].ID_SECCION, herra.Decrypt(res[i].TELEFONO));
                Response.Write(table);
            }
        }

        [WebMethod]
        public static TB_Secciones[] GetSecciones()
        {
           return sec.GetInfo();
        }

        [WebMethod]
        public static TB_Niveles[] GetNiveles()
        {
            return niv.GetInfo();
        }

        [WebMethod]
        public static TB_Parentesco[] GetParentesco()
        {
            return par.GetInfo();
        }
        
        [WebMethod]
        public static void Ingresar(string E_Cedula, string E_Nombre, string E_Apellidos, string E_Telefono, string E_Email, string E_Direccion, string E_Padecimientos, string E_Nivel, string E_Seccion, string EN_Cedula, string EN_Nombre, string EN_Apellidos,string EN_Email, string EN_TelefonoRes, string EN_TelefonoTra, string EN_TelefonoMov, string EN_Direccion, string EN_Parentesco, string EN_Lugar, string EN_Ocupacion)
        {
            if (EN_TelefonoRes == string.Empty)
            {
                EN_TelefonoRes = "No posee";
            }

            if (EN_TelefonoTra == string.Empty)
            {
                EN_TelefonoTra = "No posee";
            }

            if (EN_TelefonoMov == string.Empty)
            {
                EN_TelefonoRes = "No posee";
            }

            if (EN_Email == string.Empty)
            {
                EN_Email = "No posee";
            }

            if (EN_Lugar == string.Empty)
            {
                EN_Lugar = "No posee";
            }

            if (EN_Ocupacion == string.Empty)
            {
                EN_Ocupacion = "No aplica";
            }

            var Encargado = new TB_Encargados
            {
                ID_ENCARGADO = herra.Encrypt(EN_Cedula),
                NOMBRE = herra.Encrypt(EN_Nombre.ToUpper()),
                APELLIDOS = herra.Encrypt(EN_Apellidos.ToUpper()),
                EMAIL = herra.Encrypt(EN_Email.ToUpper()),
                TEL_RESIDENCIA = herra.Encrypt(EN_TelefonoRes),
                TEL_TRABAJO = herra.Encrypt(EN_TelefonoTra),
                TEL_MOVIL = herra.Encrypt(EN_TelefonoMov),
                ID_PARENTESCO = Convert.ToInt32(EN_Parentesco),
                
                LUGAR_TRABAJO = herra.Encrypt(EN_Lugar.ToUpper()),
                OCUPACION = herra.Encrypt(EN_Ocupacion.ToUpper())                
            };

            enc.Insertar(Encargado);

            if (E_Email == string.Empty)
            {
                E_Email = "No posee";
            }

            if (E_Padecimientos == string.Empty)
            {
                E_Padecimientos = "No posee";
            }
            
            var Estudiante = new TB_Estudiantes
            {
                ID_ESTUDIANTE = herra.Encrypt(E_Cedula),
                ID_SECCION = E_Seccion,
                ID_ENCARGADO = herra.Encrypt(EN_Cedula),
                ID_NIVEL = Convert.ToInt32(E_Nivel),
                NOMBRE = herra.Encrypt(E_Nombre.ToUpper()),
                APELLIDOS = herra.Encrypt(E_Apellidos.ToUpper()),
                TELEFONO = herra.Encrypt(E_Telefono),
                EMAIL = herra.Encrypt(E_Email.ToUpper()),
                DIRECCION = herra.Encrypt(E_Direccion.ToUpper()),
                PADECIMIENTOS = herra.Encrypt(E_Padecimientos.ToUpper()),
                ABANDONO = false,
                ANO_GRADUACION = herra.Encrypt("0"),
                GRADUADO = false
            };

            est.Insertar(Estudiante);

            for (int i = 1; i <= cur.GetCant(); i++)
            {
                var NotasEst = new TB_Notas
                {
                    ID_ESTUDIANTE = herra.Encrypt(E_Cedula),
                    ID_CURSO = i,
                    PRIMER_PERIODO = 0,
                    SEGUNDO_PERIODO = 0,
                    TERCER_PERIODO = 0,
                    CONVOCATORIA_I = 0,
                    CONVOCATORIA_II = 0,
                    CONVOCATORIA_III = 0,
                    PROMEDIO = 0,
                    PROMOCION = DateTime.UtcNow.Year.ToString()
                };

                cal.CrearNotasEst(NotasEst);
            }
        }

        [WebMethod]
        public static void Eliminar(string Id)
        {
            Id = herra.Encrypt(Id);
            var res = est.Buscar(Id);

            est.Eliminar(Id);
            enc.Eliminar(res[0].ID_ENCARGADO);
        }
        
        [WebMethod]
        public static TB_Estudiantes[] GetInfo(string Id)
        {
            Id = herra.Encrypt(Id);
            var res = est.Buscar(Id);

            res[0].ID_ESTUDIANTE = herra.Decrypt(res[0].ID_ESTUDIANTE);
            res[0].NOMBRE = herra.CapitalizeByWord(herra.Decrypt(res[0].NOMBRE));
            res[0].APELLIDOS = herra.CapitalizeByWord(herra.Decrypt(res[0].APELLIDOS));
            res[0].TELEFONO = herra.Decrypt(res[0].TELEFONO);
            res[0].EMAIL = herra.Decrypt(res[0].EMAIL).ToLower();
            res[0].PADECIMIENTOS = herra.Capitalize(herra.Decrypt(res[0].PADECIMIENTOS));
            res[0].DIRECCION = herra.Capitalize(herra.Decrypt(res[0].DIRECCION));
            res[0].ANO_GRADUACION = herra.Decrypt(res[0].ANO_GRADUACION);

            return res;
        }
        
        [WebMethod]
        public static void Actualizar(string U_Cedula, string U_Nombre, string U_Apellidos, string U_Telefono, string U_Email, string U_Graduado, string U_Abandono, string U_AnoGraduacion, string U_Grado, string U_Seccion, string U_Padecimientos, string U_Direccion)
        {
            var Abandono_ = false;
            var Graduado_ = false;
            var Encargado_ = string.Empty;

            Debug.WriteLine(U_Abandono);
            Debug.WriteLine(U_Graduado);

            if (U_Abandono == "2")
            {
                Abandono_ = true;
            }

            if (U_Graduado == "2")
            {
                Graduado_ = true;
            }

            Encargado_ = est.Buscar(herra.Encrypt(U_Cedula))[0].ID_ENCARGADO;

            var Estudiante = new TB_Estudiantes
            {
                ID_ESTUDIANTE = herra.Encrypt(U_Cedula),
                ID_ENCARGADO = Encargado_,
                ID_SECCION = U_Seccion,
                ID_NIVEL = Convert.ToInt32(U_Grado),
                NOMBRE = herra.Encrypt(U_Nombre.ToUpper()),
                APELLIDOS = herra.Encrypt(U_Apellidos.ToUpper()),
                TELEFONO = herra.Encrypt(U_Telefono),
                EMAIL = herra.Encrypt(U_Email.ToUpper()),
                DIRECCION = herra.Encrypt(U_Direccion.ToUpper()),
                PADECIMIENTOS = herra.Encrypt(U_Padecimientos.ToUpper()),
                ABANDONO = Abandono_,
                ANO_GRADUACION = herra.Encrypt(U_AnoGraduacion),
                GRADUADO = Graduado_
            };

            est.Actualizar(Estudiante);
        }
    }
}