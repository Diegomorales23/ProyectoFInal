using ES.BLL.Interfaces;
using ES.DATA;
using System.Collections.Generic;

namespace ES.BLL.Metodos
{
    public class MProfesores : IProfesores
    {
        DAL.Interfaces.IProfesores _profe;
        public MProfesores()
        {
            _profe = new DAL.Metodos.MProfesores();
        }

        // ListarProfesores();
        public List<TB_Profesores> ListarProfesores()
        {
            return _profe.ListarProfesores();
        }

        // GetId()
        public string GetId(string NOMBRE)
        {
            return _profe.GetId(NOMBRE);
        }




        // GetInfo()
        public TB_Profesores[] GetInfo()
        {
            return _profe.GetInfo();
        }

        // GetCant()
        public int GetCant()
        {
            return _profe.GetCant();
        }

        // Insertar()
        public void Insertar(TB_Profesores Profesor)
        {
            _profe.Insertar(Profesor);
        }

        // Eliminar()
        public void Eliminar(string Id)
        {
            _profe.Eliminar(Id);
        }

        // Buscar()
        public TB_Profesores[] Buscar(string Id)
        {
            return _profe.Buscar(Id);
        }

        // Actualizar()
        public void Actualizar(TB_Profesores Profesor)
        {
            _profe.Actualizar(Profesor);
        }
    }
}
