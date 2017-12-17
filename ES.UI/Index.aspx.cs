using ES.BLL.Interfaces;
using ES.BLL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ES.UI
{
    public partial class Index : System.Web.UI.Page
    {
        IEstudiantes est;
        ICursos cur;
        IUsuarios usu;
        IProfesores pro;

        public Index()
        {
            est = new MEstudiantes();
            cur = new MCursos();
            usu = new MUsuarios();
            pro = new MProfesores();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            usuarios.Text = usu.TotalUsuarios().ToString();
            profesores.Text = pro.GetCant().ToString();
            cursos.Text = cur.GetCant().ToString();
            estudiantes.Text = est.GetCant().ToString();
        }
    }
}