using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;
namespace ES.BLL.Interfaces
{
  public interface IGrupo_Alumnos
    {
        List<Grupo_Alumnos> ListaGrupo_Alumnos();
        // Select por PK
        Grupo_Alumnos BuscarGrupo_Alumnos(int idgrupo);
        // Insert
        void InsertarGrupo_Alumnos(Grupo_Alumnos grupo_alumnos);
        // Update
        void ActualizarGrupo_Alumnos(Grupo_Alumnos grupo_alumnos);
        // Delete
        void EliminarGrupo_Alumnos(int idgrupo);
    }
}
