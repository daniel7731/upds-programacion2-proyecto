using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaProgramacion2
{
    public partial class FVProductos : Form
    {
        private List<Producto> productos;
        public FVProductos()
        {
            InitializeComponent();
            productos = new List<Producto>();
            gridProductos.DataSource = productos;
            int halfHeight = this.Height / 2;

            gridProductos.Dock = DockStyle.Fill;
            gridProductos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gridProductos.Height = halfHeight;
            
            // ...

        }
        public void setProductos(List<Producto> productos)
        {
            this.productos = productos;
            this.gridProductos.DataSource = productos;
        }
        
    }
}
