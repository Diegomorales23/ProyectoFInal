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
{/*
    public partial class InsertarEncargado : System.Web.UI.Page
    {
        public static bool estado;
        public IEncargado enca;
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
                if (!string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtNombre.Text)
                    && !string.IsNullOrEmpty(txtApellidos.Text) && !string.IsNullOrEmpty(txtTelefono.Text)
                  ) 
                {
                    if (Utilidades.emailValido(txtEmail.Text))
                    {
                        if (Utilidades.EsNumerico(txtCedula.Text))
                        {
                            enca = new MEncargado();
                            Encargado encargado = new Encargado()
                            {
                                Nombre = txtNombre.Text,
                                Direccion = txtDireccion.Text,
                                Telefono = txtTelefono.Text,
                                Cedula = txtCedula.Text,
                                Email = txtEmail.Text,
                                Apellidos = txtApellidos.Text,
                               
                            };
                            enca.InsertarEncargado(encargado);
                            mensaje.Visible = true;
                            mensajeError.Visible = false;
                            mensajeInfo.Visible = false;
                            textoMensaje.InnerHtml = "Usuario agregado";

                        }
                        else
                        {
                            mensaje.Visible = false;
                            mensajeError.Visible = false;
                            mensajeInfo.Visible = true;
                            textomensajeInfo.InnerHtml = "El valor de Id Encargado debe ser un número";
                            
                        }
                    }
                    else
                    {
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        mensajeInfo.Visible = true;
                        textomensajeInfo.InnerHtml = "La direccion de correo es incorrecta";
                        txtEmail.Focus();
                    }
                }
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
    }*/
}