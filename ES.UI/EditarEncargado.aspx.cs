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
    public partial class EditarEncargado : System.Web.UI.Page
    {
        public IEncargado enca;
        public EditarEncargado()
        {
            enca = new MEncargado();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            divMantenimiento.Visible = false;
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");

        }

        protected void btnModifcar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtNombre.Text)
                    && !string.IsNullOrEmpty(txtEmail.Text)
                    && !string.IsNullOrEmpty(txtApellidos.Text) && !string.IsNullOrEmpty(txtTelefono.Text)
                    && !string.IsNullOrEmpty(txtEncargado.Text))
                {
                    if (Utilidades.emailValido(txtEmail.Text))
                    {
                        if (Utilidades.EsNumerico(txtEncargado.Text))
                        {
                            var IdEstudiante = enca.BuscarEncargado(txtCedula.Text).IdEncargado;
                            //var graduado = alu.BuscarAlumnos(txtCedula.Text).Graduado;
                            //var abandono = alu.BuscarAlumnos(txtCedula.Text).Abandono;

                            enca = new MEncargado();
                            Encargado encargado = new Encargado()
                            {
                                Nombre = txtNombre.Text,
                                Direccion = txtDireccion.Text,
                                Telefono = txtTelefono.Text,
                                Email = txtEmail.Text,
                                Apellidos = txtApellidos.Text,                                
                                IdEncargado = Convert.ToInt32(txtEncargado.Text),
                                Cedula = txtCedula.Text,
                               
                            };
                           enca.ActualizarEncargado(encargado);
                            mensaje.Visible = true;
                            mensajeError.Visible = false;
                            mensajeInfo.Visible = false;
                            textoMensaje.InnerHtml = "Datos actualizados";

                        }
                        else
                        {
                            mensaje.Visible = false;
                            mensajeError.Visible = false;
                            mensajeInfo.Visible = true;
                            textomensajeInfo.InnerHtml = "El valor de Id Encargado debe ser un número";
                            divMantenimiento.Visible = true;
                            txtEncargado.Focus();
                        }
                    }
                    else
                    {
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        mensajeInfo.Visible = true;
                        textomensajeInfo.InnerHtml = "La direccion de correo es incorrecta";
                        divMantenimiento.Visible = true;
                        txtEmail.Focus();
                    }
                }
                else
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = false;
                    mensajeInfo.Visible = true;
                    textomensajeInfo.InnerHtml = "Todos los campos son requeridos";
                    divMantenimiento.Visible = true;
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

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var encargado = enca.BuscarEncargado(txtCedula.Text);
                if (encargado != null)
                {
                    divMantenimiento.Visible = true;

                    txtNombre.Text = encargado.Nombre;
                    txtApellidos.Text = encargado.Apellidos;
                    txtDireccion.Text =encargado.Direccion;
                    txtEmail.Text = encargado.Email.ToString();                    
                    txtTelefono.Text = encargado.Telefono.ToString();
                    txtEncargado.Text = encargado.IdEncargado.ToString();
                    
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
    }*/
}