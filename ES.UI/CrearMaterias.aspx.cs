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
    public partial class CrearMaterias : System.Web.UI.Page
    {
       
        public IMaterias mate;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != null)
                {

                    mate = new MMaterias();
                var materia = new Materias
                {
                    Nombre = txtNombre.Text

                };
                mate.InsertarMaterias(materia);
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
            txtNombre.Text = string.Empty;
        }
    }
}