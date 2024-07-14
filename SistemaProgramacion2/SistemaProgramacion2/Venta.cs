using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProgramacion2
{
    public class Venta
    {
        private List<DetalleVenta> productos;
        public  Cliente  cliente { get; set; }
        public  DateTime fecha { get; set; }
        public  string   nit { get; set; }
        public  decimal  totalVenta { get; set; }
        public Venta()
        {
            productos= new List<DetalleVenta>();
        }
        public List<DetalleVenta>  getProductos()
        {

            return productos;
        }
        public void setProductos(List<DetalleVenta> productos)
        {
            this.productos= productos;
        }
    }
}
