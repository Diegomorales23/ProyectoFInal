using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;
namespace ES.DAL.Interfaces
{
   public interface IEncargado
    {
        // Insertar()
        void Insertar(TB_Encargados Encargado);
        
        // Eliminar()
        void Eliminar(string Id);        
    }
}
