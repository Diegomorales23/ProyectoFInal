﻿using System.Collections.Generic;
using ES.DATA;

namespace ES.DAL.Interfaces
{
    public interface IMaterias
    {
        // ListarMaterias();
        List<TB_Materias> ListarMaterias();

        // GetId()
        int GetId(string NOMBRE);
    }
}
