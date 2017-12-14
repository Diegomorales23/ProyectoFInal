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
    public partial class EditarProfesor : System.Web.UI.Page
    {
        public IProfesor prof = new BLL.Metodos.MProfesor();

        protected void Page_Load(object sender, EventArgs e)
        {
            divMantenimiento.Visible = false;

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                var profesor = prof.BuscarProfesor(Convert.ToInt32(txtIdProfesor.Text));
                if (profesor != null)
                {
                    divMantenimiento.Visible = true;

                    txtNombre.Text = profesor.Nombre;
                    txtApellidos.Text = profesor.Apellidos;
                    txtDireccion.Text = profesor.Direccion;
                    txtEmail.Text = profesor.Email.ToString();
                    txtTelefono.Text = profesor.Telefono.ToString();
                    txtPadecimientos.Text = profesor.Padecimientos.ToString();

                }
                else
                {
                    mensajeInfo.Visible = false;
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textomensajeError.InnerHtml = "El profesor no existe";

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

        }

        protected void btnModifcar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtNombre.Text)
                    && !string.IsNullOrEmpty(txtEmail.Text)
                    && !string.IsNullOrEmpty(txtApellidos.Text) && !string.IsNullOrEmpty(txtTelefono.Text)
                    && !string.IsNullOrEmpty(txtPadecimientos.Text))
                {
                    //if (Utilidades.emailValido(txtEmail.Text))
                    //{
                    //    if (Utilidades.EsNumerico(txtEncargado.Text))
                    //    {
                    var IdProfesor = prof.BuscarProfesor(Convert.ToInt32(txtIdProfesor.Text)).Id_Profesor;
                    //var graduado = alu.BuscarAlumnos(txtCedula.Text).Graduado;
                    //var abandono = alu.BuscarAlumnos(txtCedula.Text).Abandono;

                    //profesor = new MProfesor();
                    TB_PROFESOR profesor = new TB_PROFESOR()
                    {
                        Nombre = txtNombre.Text,
                        Direccion = txtDireccion.Text,
                        Telefono = txtTelefono.Text,
                        Email = txtEmail.Text,
                        Apellidos = txtApellidos.Text,
                        Id_Profesor = IdProfesor,
                        Padecimientos = txtPadecimientos.Text,

                    };
                    prof.ActualizarProfesor(profesor);
                    mensaje.Visible = true;
                    mensajeError.Visible = false;
                    mensajeInfo.Visible = false;
                    textoMensaje.InnerHtml = "Datos actualizados";

                }
                //else
                //{
                //    mensaje.Visible = false;
                //    mensajeError.Visible = false;
                //    mensajeInfo.Visible = true;
                //    textomensajeInfo.InnerHtml = "El valor de Id Encargado debe ser un número";
                //    divMantenimiento.Visible = true;
                //    txtEncargado.Focus();
                //}
                //}
                //else
                //{
                //    mensaje.Visible = false;
                //    mensajeError.Visible = false;
                //    mensajeInfo.Visible = true;
                //    textomensajeInfo.InnerHtml = "La direccion de correo es incorrecta";
                //    divMantenimiento.Visible = true;
                //    txtEmail.Focus();
                //    //}
                //}
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
    }
}