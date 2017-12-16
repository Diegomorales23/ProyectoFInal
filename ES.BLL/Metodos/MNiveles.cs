using ES.BLL.Interfaces;
using ES.DATA;
using System.Collections.Generic;

namespace ES.BLL.Metodos
{
    public class MNiveles : INiveles
    {
        DAL.Interfaces.INiveles niv;

        public MNiveles()
        {
            niv = new DAL.Metodos.MNiveles();
        }
        
        // GetInfo()
        public TB_Niveles[] GetInfo()
        {
            return niv.GetInfo();
        }





        // ListarNiveles();
        public List<TB_Niveles> ListarNiveles()
        {
            return niv.ListarNiveles();
        }
        
        // GetId()
        public int GetId(string NOMBRE)
        {
            return niv.GetId(NOMBRE);
        }
    }
}
