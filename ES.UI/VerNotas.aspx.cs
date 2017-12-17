using ES.BLL.Interfaces;
using ES.BLL.Metodos;
using ES.DATA;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ES.UI
{
    public partial class VerNotas : System.Web.UI.Page
    {
        static INotas not;
        static IHerramientas herra;

        public VerNotas()
        {
            not = new MNotas();
            herra = new MHerramientas();
        }
        
        protected void MostrarNotas()
        {
            var res = not.GetInfo().ToArray();
            Debug.WriteLine(res.Length);

            for (int i = 0; i < res.Length; i++)
            {
                var table = string.Format("<tr> <td>{0}</td> <td>{1}</td> <td>{2}</td> <td>{3}</td> <td>{4}</td> <td>{5}</td> <td>{6}</td><td></td> </tr>", res[i].ID_NOTAS, herra.CapitalizeByWord(herra.Decrypt(res[i].NOMBRE)) + " " + herra.CapitalizeByWord(herra.Decrypt(res[i].APELLIDOS)), res[i].ID_SECCION, res[i].PRIMER_PERIODO, res[i].SEGUNDO_PERIODO, res[i].TERCER_PERIODO, res[i].PROMEDIO);
                Response.Write(table);
            }
        }
        
        [WebMethod]
        public static List<tempNotas_> GetInfo(string Id)
        {
            var res = not.GetInfoById(Id);
            res[0].NOMBRE = herra.Decrypt(res[0].NOMBRE);
            res[0].APELLIDOS = herra.Decrypt(res[0].APELLIDOS);
            return res; 
        }

        [WebMethod]
        public static void Actualizar(string Id, string IP, string IIP, string IIIP)
        {
            not.Actualizar(Id, IP, IIP, IIIP);
        }
    }
}