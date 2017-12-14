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
    public partial class InsertarProfesor : System.Web.UI.Page
    {
        IProfesor pro = new BLL.Metodos.MProfesor();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtNombre.Text)
                    && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPadecimientos.Text)
                    && !string.IsNullOrEmpty(txtApellidos.Text) && !string.IsNullOrEmpty(txtTelefono.Text))
                {
                    //if (Utilidades.emailValido(txtEmail.Text))  // Utilidades es el _herra version Marcos (te lo volaste)
                    //{
                    //    if (Utilidades.EsNumerico(txtEncargado.Text))
                    //    {
                             //est = new MProfesor();
                            TB_PROFESOR prof = new TB_PROFESOR()
                            {
                                Nombre = txtNombre.Text,
                                Direccion = txtDireccion.Text,
                                Telefono = txtTelefono.Text,
                                Email = txtEmail.Text,
                                Apellidos = txtApellidos.Text,
                                Padecimientos = txtPadecimientos.Text,
                          
                            };
                            pro.InsertarProfesor(prof);
                            mensaje.Visible = true;
                            mensajeError.Visible = false;
                            mensajeInfo.Visible = false;
                            textoMensaje.InnerHtml = "Profesor agregado";

                        }
                //else
                //{
                //    mensaje.Visible = false;
                //    mensajeError.Visible = false;
                //    mensajeInfo.Visible = true;
                //    textomensajeInfo.InnerHtml = "El valor de Id Encargado debe ser un número";
                //    txtEncargado.Focus();
                //}
                //}
                //else
                //{
                //    mensaje.Visible = false;
                //    mensajeError.Visible = false;
                //    mensajeInfo.Visible = true;
                //    textomensajeInfo.InnerHtml = "La direccion de correo es incorrecta";
                //    txtEmail.Focus();
                //}
                else
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = false;
                    mensajeInfo.Visible = true;
                    textomensajeInfo.InnerHtml = "Todos los campos son requeridos";
                    txtEmail.Focus();
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

        }
    }
}