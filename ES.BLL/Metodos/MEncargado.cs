using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.BLL.Interfaces;
using ES.DATA;

namespace ES.BLL.Metodos
{
    public class MEncargado : IEncargado
    {
        private DAL.Interfaces.IEncargado enca;
        public MEncargado()
        {
            enca = new DAL.Metodos.MEncargado();
        }
        public void ActualizarEncargado(Encargado encargado)
        {
            enca.ActualizarEncargado(encargado);
        }

        public Encargado BuscarEncargado(string cedula)
        {
            return enca.BuscarEncargado(cedula);
        }

        public void EliminarEncargado(int idEncargado)
        {
            enca.EliminarEncargado(idEncargado);
        }

        public void InsertarEncargado(Encargado encargado)
        {
            enca.InsertarEncargado(encargado);
        }

        public List<Encargado> ListaEncargado()
        {
            return enca.ListaEncargado();
        }
    }
}
