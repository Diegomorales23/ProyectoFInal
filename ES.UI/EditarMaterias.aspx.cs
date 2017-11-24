using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ES.BLL.Interfaces;
using ES.BLL.Metodos;
using ES.DATA;
namespace ES.UI
{
    public partial class EditarMaterias : System.Web.UI.Page
    {
        public IMaterias mate;
        public EditarMaterias()
        {
            mate = new MMaterias();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            divMantenimiento.Visible = false;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var materias = mate.BuscarMaterias(Convert.ToInt32(txtIdMateria.Text));
                if (materias != null)
                {
                    divMantenimiento.Visible = true;

                    txtNombre.Text = materias.Nombre;
                 
                }
                else
                {
                    mensajeInfo.Visible = false;
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textomensajeError.InnerHtml = "El alumno no existe";

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

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void btnModifcar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdMateria.Text) && !string.IsNullOrEmpty(txtNombre.Text))
                {

                    mate = new MMaterias();
                    Materias materia = new Materias
                    {
                        Nombre = txtNombre.Text,
                        IdMateria= Convert.ToInt32( txtIdMateria.Text)
                    };
                    mate.ActualizarMaterias(materia);
                    mensaje.Visible = true;
                    mensajeError.Visible = false;
                    mensajeInfo.Visible = false;
                    textoMensaje.InnerHtml = "Materia agregado";
                }

                else
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = false;
                    mensajeInfo.Visible = true;
                    textomensajeInfo.InnerHtml = "Error";
                    txtNombre.Focus();
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

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdMateria.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }
    }
}