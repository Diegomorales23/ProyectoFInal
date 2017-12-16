using ES.BLL.Interfaces;
using ES.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.BLL.Metodos
{
    public class MParentesco : IParentesco
    {
        DAL.Interfaces.IParentesco par;
        public MParentesco()
        {
            par = new DAL.Metodos.MParentesco();
        }

        // GetInfo()
        public TB_Parentesco[] GetInfo()
        {
            return par.GetInfo();
        }
    }
}
