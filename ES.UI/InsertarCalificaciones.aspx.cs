using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using ES.BLL.Interfaces;
using ES.BLL.Metodos;
using ES.DATA;
using ES.DAL.Metodos;

namespace ES.UI
{
    public partial class InsertarCalificaciones : System.Web.UI.Page
    {
        INotas cal = new BLL.Metodos.MNotas();
        IMaterias mat = new BLL.Metodos.MMaterias();
        IAlumnos est = new BLL.Metodos.MAlumnos();

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarMaterias();
            CargarEstudiantes();


        }

        private void CargarMaterias()
        {
            var Materias = mat.ListarMaterias().Select(x => x.Nombre);
            ddlMateria.DataSource = Materias;
            ddlMateria.DataBind();
        }

        private void CargarEstudiantes()
        {
            var Estudiantes = est.ListaAlumnos().Select(x => x.Cedula);
            ddlCedula.DataSource = Estudiantes;
            ddlCedula.DataBind();
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        protected void btnLimpieza_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control _textbox in this.Controls)
                {
                    TextBox textBox = _textbox as TextBox;
                    if (textBox.Text != null)
                    {
                        textBox.Text = string.Empty;
                    }

                }
            }
            catch (Exception)
            {
                mensajeInfo.Visible = false;
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textomensajeError.InnerHtml = "Hubo un error";
            }
        }
    }
}