using ES.DATA;
using System.Collections.Generic;

namespace ES.BLL.Interfaces
{
    public interface INiveles
    {
        // GetInfo()
        TB_Niveles[] GetInfo();


        // ListarNiveles();
        List<TB_Niveles> ListarNiveles();

        // GetId()
        int GetId(string NOMBRE);
    }
}
