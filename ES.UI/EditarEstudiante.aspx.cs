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
{
    /*
    public partial class EditarEstudiante : System.Web.UI.Page
    {
        public IAlumnos alu;
        public EditarEstudiante()
        {
            alu = new MAlumnos();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            divMantenimiento.Visible = false;
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtNombre.Text)
                    && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPadecimientos.Text)
                    && !string.IsNullOrEmpty(txtApellidos.Text) && !string.IsNullOrEmpty(txtTelefono.Text)
                    && !string.IsNullOrEmpty(txtEncargado.Text))
                {
                    if (Utilidades.emailValido(txtEmail.Text))
                    {
                        if (Utilidades.EsNumerico(txtEncargado.Text))
                        {
                            var IdEstudiante = alu.BuscarAlumnos(txtCedula.Text).IdAlumno;
                            //var graduado = alu.BuscarAlumnos(txtCedula.Text).Graduado;
                            //var abandono = alu.BuscarAlumnos(txtCedula.Text).Abandono;

                            alu = new MAlumnos();
                            Alumnos alumno = new Alumnos()
                            {
                                Nombre = txtNombre.Text,
                                Direcion = txtDireccion.Text,
                                Telefono = txtTelefono.Text,
                                Email = txtEmail.Text,
                                Apellidos = txtApellidos.Text,
                                Padecimientos = txtPadecimientos.Text,
                                IdEncargado = Convert.ToInt32(txtEncargado.Text),
                                IdAlumno = IdEstudiante,
                                Cedula = txtCedula.Text,
                                Graduado = chGraduado.Checked,
                                Abandono = chAbandono.Checked,
                                AñoGraduacion = txtAñoGraduacion.Text,
                            };
                            alu.ActualizarAlumnos(alumno);
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
                var Alumno = alu.BuscarAlumnos(txtCedula.Text);
                if (Alumno != null)
                {
                    divMantenimiento.Visible = true;

                  
                        txtNombre.Text = Alumno.Nombre;
                        txtApellidos.Text = Alumno.Apellidos;
                        txtDireccion.Text = Alumno.Direcion;
                        txtEmail.Text = Alumno.Email.ToString();
                        txtPadecimientos.Text = Alumno.Padecimientos;
                        txtTelefono.Text = Alumno.Telefono.ToString();
                        txtEncargado.Text = Alumno.IdEncargado.ToString();
                        chAbandono.Checked = Alumno.Abandono;
                        chGraduado.Checked = Alumno.Graduado;
                        txtAñoGraduacion.Text = Alumno.AñoGraduacion;
                   
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