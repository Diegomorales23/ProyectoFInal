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
    public partial class BuscarEncargado : System.Web.UI.Page
    {
        public IEncargado enca;
        public BuscarEncargado()
        {
            enca= new MEncargado();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        void CargarDatos()
        {
            List<Encargado> listaEncargado =enca.ListaEncargado();

            gvDatos.DataSource = listaEncargado.Select(x => new {

                x.IdEncargado,
                x.Cedula,
                x.Nombre,
                x.Apellidos,
                x.Telefono,
                x.Email,
               x.Direccion
               
               
            });

            gvDatos.DataBind();
        }
    }
}