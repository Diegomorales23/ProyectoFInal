using ES.DATA;
using System.Collections.Generic;

namespace ES.DAL.Interfaces
{
  public interface INotas
    {
        void CrearNotasEst(TB_Notas Notas);

        List<tempNotas> GetInfo();

        // GetInfo()
        List<tempNotas_> GetInfoById(string Id);

        void Actualizar(string Id, string IP, string IIP, string IIIP);
    }
}
