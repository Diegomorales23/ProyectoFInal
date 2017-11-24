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
    public partial class BuscarEstudiantes : System.Web.UI.Page
    {
        public IAlumnos alu;
        public BuscarEstudiantes()
        {
            alu = new MAlumnos();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        void CargarDatos()
        {
            List<Alumnos> listaAlumnos = alu.ListaAlumnos();
           
            gvDatos.DataSource = listaAlumnos.Select(x => new {
                x.IdAlumno,
                x.Cedula,
                x.Nombre,
                x.Apellidos,
                x.Telefono,
                x.Email,
                x.Padecimientos,
                x.Direcion,
                x.IdEncargado,
                x.Abandono,
                x.Graduado,
                x.AñoGraduacion,
            });
            gvDatos.DataBind();
        }
    }*/
}