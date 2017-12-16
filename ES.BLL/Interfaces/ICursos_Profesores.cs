using ES.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.BLL.Interfaces
{
    public interface ICursos_Profesores
    {
        // Insertar()
        void Insertar(TB_Cursos_Profesores NuevaRel);

        // Eliminar()
        void Eliminar(int Id);
    }
}
