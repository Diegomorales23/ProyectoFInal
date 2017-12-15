using ES.BLL.Interfaces;
using ES.DATA;

namespace ES.BLL.Metodos
{
    public class MProfesores : IProfesores
    {
        DAL.Interfaces.IProfesores _profe;
        public MProfesores()
        {
            _profe = new DAL.Metodos.MProfesores();
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
