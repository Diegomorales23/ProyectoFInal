using System;
using ES.BLL.Interfaces;
using ES.DATA;
using System.Collections.Generic;

namespace ES.BLL.Metodos
{
    public class MCursos : ICursos
    {
        DAL.Interfaces.ICursos cur;
        public MCursos()
        {
            cur = new DAL.Metodos.MCursos();
        }

        // Insertar()
        public void Insertar(TB_Cursos NuevoCurso)
        {
            cur.Insertar(NuevoCurso);
        }
        
        // GetCant()
        public int GetCant()
        {
            return cur.GetCant();
        }

        // GetInfo()
        public List<tempCursos> GetInfo()
        {
            return cur.GetInfo();
        }

        // Eliminar()
        public void Eliminar(int Id)
        {
            cur.Eliminar(Id);
        }
    }
}
