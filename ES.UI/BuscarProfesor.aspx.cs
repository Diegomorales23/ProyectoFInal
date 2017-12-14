using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ES.BLL.Interfaces;
using ES.BLL.Metodos;
using ES.DATA;
using ES.DAL.Metodos;


namespace ES.UI
{
    public partial class BuscarProfesor : System.Web.UI.Page
    {
        public IProfesor prof = new BLL.Metodos.MProfesor();

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        void CargarDatos()
        {
            List<TB_PROFESOR> listaProfesores = prof.ListaProfesor();

            gvProfesores.DataSource = listaProfesores.Select(x => new {
                x.Id_Profesor,
                x.Nombre,
                x.Apellidos,
                x.Telefono,
                x.Email,
                x.Padecimientos,
                x.Direccion,
            });
            gvProfesores.DataBind();
        }
    }
}