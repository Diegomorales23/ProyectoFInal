using ES.BLL.Interfaces;
using ES.BLL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ES.UI
{
    public partial class AdmEstudiantes : System.Web.UI.Page
    {
        private static IEstudiantes _est;
        private static IHerramientas _herra;

        public AdmEstudiantes()
        {
            _est = new MEstudiantes();
            _herra = new MHerramientas();
        }

        protected void Page_Load(object sender, EventArgs e) { }

        protected void MostrarInfo()
        {
            var res = _est.GetEstudiantesInfo();
            /*for (int i = 0; i < _est.ContarEstudiantes(); i++)
            {
                var table = string.Format("<tr> <td>{0}</td> <td>{1}</td> <td>{2}</td> <td>{3} / 42</td> <td></td> </tr>", _tools.Decrypt(res[i].IdPanel).ToUpper(), _tools.Capitalize(_tools.Decrypt(res[i].Area)), _tools.Capitalize(_tools.Decrypt(res[i].Description)), _tools.Decrypt(res[i].SpacesAvailable));
                Response.Write(table);
            }*/
        }

    }
}