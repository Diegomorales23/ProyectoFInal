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
    public partial class BuscarMaterias : System.Web.UI.Page
    {
        public IMaterias mate;
        public BuscarMaterias()
        {
            mate = new MMaterias();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        void CargarDatos()
        {
            List<Materias> listaMaterias = mate.ListarMaterias();

            gvDatos.DataSource = listaMaterias.Select(x => new {
                x.IdMateria,
                x.Nombre
           
            });
            gvDatos.DataBind();
        }
    }
}