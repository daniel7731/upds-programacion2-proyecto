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
    public partial class FProducto : Form
    {
        private List<Producto> productos;
        public FProducto()
        {
            InitializeComponent();
            productos = new List<Producto>();
        }
        public void setProductos(List<Producto> productos)
        {
            this.productos = productos;
        }
        public List<Producto> getProductos() { return productos; }
        private void guardarProducto(string codigo, string nombre, decimal precio, decimal precioIn, string marca)
        {
            Console.WriteLine(codigo);
            Console.WriteLine(nombre);
            Console.WriteLine(precio);
            Console.WriteLine(precioIn);
            Console.WriteLine(marca);
            Producto producto = new Producto();
            producto.cantidad = 10;
            producto.nombre = nombre;
            producto.precio = precio;
            producto.precioInventario = precioIn;
            producto.marca = marca;
            producto.codigo = codigo;
            productos.Add(producto);

            
        }

        private void buttonGuarda_Click(object sender, EventArgs e)
        {
            string codigo = textCodigo.Text;
            string nombre = textNombre.Text;
            decimal precio = numericPrecio.Value;
            decimal precioInventario = numericInventario.Value;
            object item = comboBox1.SelectedItem;
            string marca = item.ToString();
            guardarProducto(codigo, nombre, precio, precioInventario, marca);
            MessageBox.Show("El producto se guardo en la lista");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = textCodigo.Text;
            string nombre = textNombre.Text;
            decimal precio = numericPrecio.Value;
            decimal precioInventario = numericInventario.Value;
            object item = comboBox1.SelectedItem;
            string marca = item.ToString();
            guardarProducto(codigo, nombre, precio, precioInventario, marca);
            this.Hide();
        }
    }
}
