using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.BLL.Interfaces;
using ES.DATA;
namespace ES.BLL.Metodos
{
    public class MNotas : INotas
    {
        private DAL.Interfaces.INotas _not;
        public MNotas()
        {
            _not = new DAL.Metodos.MNotas();
        }


        public void CrearNotasEst(TB_Notas Notas)
        {
            _not.CrearNotasEst(Notas);
        }        
    }
}
