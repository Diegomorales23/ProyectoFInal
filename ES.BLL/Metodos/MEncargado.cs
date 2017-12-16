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

        public void Insertar(TB_Encargados Encargado)
        {
            enca.Insertar(Encargado);
        }

        public void Eliminar(string Id)
        {
            enca.Eliminar(Id);
        }        
    }
}
