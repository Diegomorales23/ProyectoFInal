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
    public partial class EliminarProfesor : System.Web.UI.Page
    {
        public IProfesor prof = new BLL.Metodos.MProfesor();

        protected void Page_Load(object sender,  EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
            var profesor = prof.BuscarProfesor(Convert.ToInt32(txtIdProfesor.Text));
            prof.EliminarProfesor(Convert.ToInt32(txtIdProfesor.Text));
            }
            catch (Exception)
            {

                throw;
            }
          
        }
    }
}