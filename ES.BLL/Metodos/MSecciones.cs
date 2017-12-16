using ES.BLL.Interfaces;
using ES.DATA;

namespace ES.BLL.Metodos
{
    public class MSecciones : ISecciones
    {
        DAL.Interfaces.ISecciones sec;

        public MSecciones()
        {
            sec = new DAL.Metodos.MSecciones();
        }
        
        // GetInfo()
        public TB_Secciones[] GetInfo()
        {
            return sec.GetInfo();
        }
    }
}
