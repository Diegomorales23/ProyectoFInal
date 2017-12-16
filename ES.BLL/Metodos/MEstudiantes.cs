using ES.BLL.Interfaces;
using ES.DATA;

namespace ES.BLL.Metodos
{
    public class MEstudiantes : IEstudiantes
    {
        DAL.Interfaces.IEstudiantes est;

        public MEstudiantes()
        {
            est = new DAL.Metodos.MEstudiantes();
        }

        // GetInfo()
        public TB_Estudiantes[] GetInfo()
        {
            return est.GetInfo();
        }
        
        // GetCant()
        public int GetCant()
        {
            return est.GetCant();
        }
        
        // Insertar()
        public void Insertar(TB_Estudiantes Estudiante)
        {
            est.Insertar(Estudiante);
        }

        // Eliminar()
        public void Eliminar(string Id)
        {
            est.Eliminar(Id);
        }

        // Buscar()
        public TB_Estudiantes[] Buscar(string Id)
        {
            return est.Buscar(Id);
        }

        // Actualizar()
        public void Actualizar(TB_Estudiantes Estudiante)
        {
            est.Actualizar(Estudiante);
        }
    }
}
