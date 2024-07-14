using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProgramacion2
{
    public class DetalleVenta
    {
        public int cantidad { get; set; }
        public Producto producto { get; set; }
        public decimal precioVenta { get; set; }
    }
}
