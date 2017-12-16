using ES.BLL.Interfaces;
using ES.BLL.Metodos;
using ES.DATA;
using System;
using System.Diagnostics;
using System.Linq;
using System.Web.Services;

namespace ES.UI
{
    public partial class AdmCursos : System.Web.UI.Page
    {
        IMaterias mat;
        INiveles niv;
        IProfesores pro;
        static ICursos cur;
        static ICursos_Profesores cur_pro;
        IHerramientas herra;

        public AdmCursos()
        {
            mat = new MMaterias();
            niv = new MNiveles();
            pro = new MProfesores();
            cur = new MCursos();
            cur_pro = new MCursos_Profesores();
            herra = new MHerramientas();
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlMateria.DataSource = mat.ListarMaterias().Select(x => herra.CapitalizeByWord(x.NOMBRE));
            ddlMateria.DataBind();
            
            ddlNivel.DataSource = niv.ListarNiveles().Select(x => herra.CapitalizeByWord(x.NOMBRE));
            ddlNivel.DataBind();
            
            ddlProfesor.DataSource = pro.ListarProfesores().Select(x => herra.CapitalizeByWord(herra.Decrypt(x.NOMBRE) + " " + herra.CapitalizeByWord(herra.Decrypt(x.APELLIDOS))));
            ddlProfesor.DataBind();
        }

        protected void MostrarCursos()
        {
            var res = cur.GetInfo().ToArray();
            Debug.WriteLine(res.Length);

            for (int i = 0; i < res.Length; i++)
            {
                var table = string.Format("<tr> <td>{0}</td> <td>{1}</td> <td>{2}</td> <td>{3}</td><td></td> </tr>", res[i].Id, herra.CapitalizeByWord(res[i].MATERIA), herra.CapitalizeByWord(res[i].NIVEL) , herra.CapitalizeByWord(herra.Decrypt(res[i].PROFESOR)));
                Response.Write(table);
            }
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(ddlMateria.SelectedValue.ToString());
            var IdMateria = mat.GetId(ddlMateria.SelectedItem.ToString());
            var IdNivel = niv.GetId(ddlNivel.SelectedItem.ToString());
            var IdProfesor = pro.GetId(ddlProfesor.SelectedItem.Value.ToString());

            var NuevoCurso = new TB_Cursos
            {
                ID_MATERIA = IdMateria,
                ID_NIVEL = IdNivel
            };

            cur.Insertar(NuevoCurso);

            var NuevaRel = new TB_Cursos_Profesores
            {
                ID_CURSO = cur.GetCant(),
                ID_PROFESOR = IdProfesor
            };

            cur_pro.Insertar(NuevaRel);

        }

        [WebMethod]
        public static void Eliminar(int Id)
        {
            cur_pro.Eliminar(Id);
            cur.Eliminar(Id);
        }
    }
}