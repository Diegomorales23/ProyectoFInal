using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;
namespace ES.BLL.Interfaces
{
   public interface IGrupo_Profesor
    {
        List<Grupo_Profesor> ListaGrupo_Profesor();
        // Select por PK
        Grupo_Profesor BuscarGrupo_Profesor(int idgrupo);
        // Insert
        void InsertarGrupo_Profesor(Grupo_Profesor grupo_profesor);
        // Update
        void ActualizarGrupo_Profesor(Grupo_Profesor grupo_profesor);
        // Delete
        void EliminarGrupo_Profesor(int idgrupo);
    }
}
