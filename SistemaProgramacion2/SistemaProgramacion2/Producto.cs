using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProgramacion2
{
    public class Producto
    {
        public string  codigo { get; set; }
        public string  nombre { get; set; }
        public string  marca  { get; set; }
        public decimal precio { get; set;}
        public decimal precioInventario { get; set; }
        public int     cantidad { get; set; }
    }
}
