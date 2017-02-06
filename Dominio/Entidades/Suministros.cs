using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
   public class Suministros
    {
        public int ID_Suministro { get; set; }
        public string Sumi_Fabricante { get; set; }
        public string Sumi_Serie { get; set; }
        public string Sumi_Modelo { get; set; }
        public string Sumi_Descripcion { get; set; }
        public string Sumi_Observaciones { get; set; }
        public string Sumi_Estatus { get; set; }
        public string Sumi_Tipo { get; set; }
        public DateTime Sumi_FechaAlta { get; set; }
        public string Sumi_Factura { get; set; }
        public int Sumi_Cantidad { get; set; }
        public int Sumi_CantidadDisponible { get; set; }
        public string Sumi_Nombre { get; set; }
        public decimal Sumi_precio { get; set; }
        public string Sumi_Proveedor { get; set; }
        public decimal Sumi_PrecioUnitario { get; set; }
    }
}
