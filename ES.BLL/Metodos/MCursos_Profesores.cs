using ES.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES.DATA;

namespace ES.BLL.Metodos
{
    public class MCursos_Profesores : ICursos_Profesores
    {
        private DAL.Interfaces.ICursos_Profesores cur_pro;
        public MCursos_Profesores()
        {
            cur_pro = new DAL.Metodos.MCursos_Profesores();
        }

        public void Insertar(TB_Cursos_Profesores NuevaRel)
        {
            cur_pro.Insertar(NuevaRel);
        }

        public void Eliminar(int Id)
        {
            cur_pro.Eliminar(Id);
        }

    }
}
