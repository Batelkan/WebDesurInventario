using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
   public class Computadoras
    {
        public int ID_Computadora { get; set; }
        public string Cpu_Fabricante { get; set; }
        public string Cpu_Serie { get; set; }
        public string Cpu_Modelo { get; set; }
        public string Cpu_Descripcion { get; set; }
        public string Cpu_Observaciones { get; set; }
        public string Cpu_Estatus { get; set; }
        public string Cpu_Tipo { get; set; }
        public DateTime Cpu_FechaAlta { get; set; }
        public string Cpu_Factura { get; set; }
        public decimal Cpu_precio { get; set; }
        public string Cpu_Proveedor { get; set; }
        public string Cpu_Procesador { get; set; }
        public string Cpu_Memoria { get; set; }
        public string Cpu_Almacenamiento { get; set; }
        public string Cpu_Video { get; set; }
        public string Cpu_TarjetaMadre { get; set; }
        public string Cpu_IO { get; set; }
        public string Cpu_Mac { get; set; }
        public string Cpu_IP { get; set; }
    }
}
