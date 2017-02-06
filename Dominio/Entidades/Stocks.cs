using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
  public  class Stocks
    {
        public int ID_Stock { get; set; }
        public int ID_Usuario { get; set; }
        public int ID_Departamento { get; set; }
        public int ID_Suministro { get; set; }
        public int ID_Computadora { get; set; }
        public int ID_UnidadNegocio { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public string Observacion { get; set; }
        public string Autorizo { get; set; }
    }
}
