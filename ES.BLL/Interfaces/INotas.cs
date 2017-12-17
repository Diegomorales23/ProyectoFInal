using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;
namespace ES.BLL.Interfaces
{
   public interface INotas
    {
        void CrearNotasEst(TB_Notas Notas);

        List<tempNotas> GetInfo();

        void Actualizar(string Id, string IP, string IIP, string IIIP);

        // GetInfo()
        List<tempNotas_> GetInfoById(string Id);
    }
}
