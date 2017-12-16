using System.Collections.Generic;
using ES.BLL.Interfaces;
using ES.DATA;
namespace ES.BLL.Metodos
{
    public class MMaterias : IMaterias
    {
        DAL.Interfaces.IMaterias mat;

        public MMaterias()
        {
            mat = new DAL.Metodos.MMaterias();
        }

        // ListarMaterias();
        public List<TB_Materias> ListarMaterias()
        {
           return mat.ListarMaterias();
        }

        // GetId()
        public int GetId(string NOMBRE)
        {
            return mat.GetId(NOMBRE);
        }
    }
}
