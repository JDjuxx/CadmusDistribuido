using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadmusCursosOnline.Entidades
{
    class CursoEnt
    {
        public int IdCurso { get; set; }
        public String Nombre { get; set; }
        public decimal Costo { get; set; }
        public int Horas { get; set; }
        public int IdDireccion { get; set; }

    }
}
