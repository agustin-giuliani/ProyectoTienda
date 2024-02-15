using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int Totalproducto { get; set; }
        public decimal Montototal { get; set; }
        public string Contacto { get; set; }
        public string IdDistrito { get; set; }
        public string Telefono { get; set; }
        public string Dirreccion { get; set; }
        public string IdTransacciones { get; set; }

        public List<DetalleVenta> oDetalleVenta { get; set; }
    }
}
