using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;
namespace ES.DATA
{
    public class Materias
    {
        [AutoIncrement]
        public int IdMateria { get; set; }

        public string Nombre { get; set; }

    }
}
