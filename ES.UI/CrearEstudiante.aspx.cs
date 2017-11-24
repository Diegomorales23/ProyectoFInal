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


namespace ES.UI
{/*
    public partial class AgregarAlumno : System.Web.UI.Page
    {
        public static bool estado;
        public IAlumnos alu;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        //public bool ValidarVacios(Control _textbox) // valida si hay alguna caja de texto vacia
        //{
        //    estado = false;
        //    var Lista = _textbox;
        //    try
        //    {
        //        foreach (Control item in Controls)
        //        {
        //            TextBox textBox = _textbox as TextBox;
        //            if (textBox == null)
        //            {
        //                estado = true;
        //            }

        //        }
        //    }
        //    catch (Exception)
        //    {
        //        mensajeInfo.Visible = false;
        //        mensaje.Visible = false;
        //        mensajeError.Visible = true;
        //        textomensajeError.InnerHtml = "Hubo un error";
        //    }
        //    return estado;
        //}
        //public void Limpiar() // Limpia las cajas de texto
        //{
        //    try
        //    {
        //        foreach (Control _textbox in this.Controls)
        //        {
        //            TextBox textBox = _textbox as TextBox;
        //            if (textBox.Text != null)
        //            {
        //                textBox.Text = string.Empty;
        //            }

        //        }
        //    }
        //    catch (Exception)
        //    {
        //        mensajeInfo.Visible = false;
        //        mensaje.Visible = false;
        //        mensajeError.Visible = true;
        //        textomensajeError.InnerHtml = "Hubo un error";
        //    }
        //}
        protected void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtNombre.Text)
                    && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPadecimientos.Text)
                    && !string.IsNullOrEmpty(txtApellidos.Text) && !string.IsNullOrEmpty(txtTelefono.Text)
                    && !string.IsNullOrEmpty(txtEncargado.Text)&& !string.IsNullOrEmpty(txtCedula.Text))
                {
                    if (Utilidades.emailValido(txtEmail.Text))
                    {
                        if (Utilidades.EsNumerico(txtEncargado.Text))
                        {
                            alu = new MAlumnos();
                            Alumnos alumno = new Alumnos()
                            {
                                Nombre = txtNombre.Text,
                                Direcion = txtDireccion.Text,
                                Telefono = txtTelefono.Text,
                                Cedula = txtCedula.Text,
                                Email = txtEmail.Text,
                                Apellidos = txtApellidos.Text,
                                Padecimientos = txtPadecimientos.Text,
                                IdEncargado = Convert.ToInt32(txtEncargado.Text),
                                Abandono = false,
                                Graduado = false,
                                AñoGraduacion = "Pendiete",
                            };
                            alu.InsertarAlumnos(alumno);
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
                            txtEncargado.Focus();
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
            //Limpiar();
        }
    }
    */
}