using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCapaEntidades
{
    public class Cuatrimestre
    {
        public int Id_Cuatrimestres { get; set; }
        public string Periodo { get; set; }
        public int Anio { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public string Extra { get; set; }
    }
}
