using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
    public class Factura
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Itebis { get; set; }
        public decimal Descuento { get; set; }
        public decimal TotalGeneral => (Cantidad * PrecioUnitario) + Itebis - Descuento;
    }
}
