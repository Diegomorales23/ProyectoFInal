using ES.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.BLL.Metodos
{
    public class MParentesco : IParentesco
    {
        private DAL.Interfaces.IParentesco _par;
        public MParentesco()
        {
            _par = new DAL.Metodos.MParentesco();
        }

        // GetIdParentesco()
        public string GetIdParentesco(string Parentesco)
        {
            return _par.GetIdParentesco(Parentesco);
        }
    }
}
