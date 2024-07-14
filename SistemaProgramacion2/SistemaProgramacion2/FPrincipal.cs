using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaProgramacion2
{
    public partial class Principal : Form
    {
        private string fclientes  = "";
        private string fproductos = "";
        private string fventas = "";
        private FConfiguracion configuracion;
        private FProducto formularioProductos;
        private FVProductos vistaProductos;
        private AboutDialogo about;
        private List<Cliente>  listaCliente;
        private List<Producto> listaProducto;
        private List<Venta>    listaVenta;
        public Principal()
        {
            InitializeComponent();
            formularioProductos= new FProducto();
            vistaProductos= new FVProductos();
            configuracion= new FConfiguracion();
            about = new AboutDialogo();
            cargadoEstatico();

        }
        public void cargadoEstatico()
        {
            listaProducto = new List<Producto>();
            listaVenta= new List<Venta>();
            listaCliente= new List<Cliente>();
            Producto p1 = crearProductoStatico("C1", "SHAMPOO"  , 10, 5, "HEADSHOWER");
            Producto p2 = crearProductoStatico("C2", "LECHE"    , 10, 5, "PIL");
            Producto p3 = crearProductoStatico("C3", "QUESO"    , 10, 5, "MENONA");
            listaProducto.Add(p1);
            listaProducto.Add(p2);
            listaProducto.Add(p3);
            Cliente c1 = crearClienteStatico(1, "DARIL FERNANDEZ", "7000000");
            Cliente c2 = crearClienteStatico(2, "DAMUEL CEBALLOS", "7000000");
            Cliente c3 = crearClienteStatico(3, "ROGER PINTO", "7000000");
            listaCliente.Add(c1);
            listaCliente.Add(c2);
            listaCliente.Add(c3);
            dataGridClientes.DataSource = listaCliente;
            int halfHeight = this.Height / 2;

            dataGridClientes.Dock = DockStyle.Fill;
            dataGridClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridClientes.Height = halfHeight;
        }
        public Producto crearProductoStatico(string codigo, string nombre, decimal precio , decimal precioInv , string marca)
        {

            Producto p = new Producto();
            p.precio = precio;
            p.codigo = codigo;
            p.marca  = marca;
            p.nombre = nombre;
            p.precioInventario = precioInv;
            return p;
        }
        public Cliente crearClienteStatico(int id, string nombre, string nit)
        {
            Cliente cliente = new Cliente();
            cliente.id = id;
            cliente.nit = nit;
            cliente.nombre= nombre;
            return cliente;
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioProductos.setProductos(listaProducto);
            formularioProductos.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vistaProductos.setProductos(this.listaProducto);
            vistaProductos.ShowDialog(this);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configuracion.fventas = fventas;
            configuracion.fproductos= fproductos;
            configuracion.fclientes= fclientes;
            configuracion.ShowDialog();
            fventas = configuracion.fventas;
            fproductos = configuracion.fproductos; 
            fclientes = configuracion.fclientes; 

        }

        private void clienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = saveFileDialogClientes.ShowDialog();
            if (resultado == DialogResult.OK)
            {
               string fileName =  saveFileDialogClientes.FileName;
               Cliente.guardarClientes(listaCliente, fileName);
               fclientes = fileName; 
            }
            else{
           
            }
        }

        private void buttonCargarClientes_Click(object sender, EventArgs e)
        {
            DialogResult resultado = openFileDialogClientes.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string fileName = openFileDialogClientes.FileName;
                List<Cliente> cls = Cliente.leerClientes(fileName);
                this.listaCliente= cls;
                dataGridClientes.DataSource = listaCliente;
            }
            else
            {

            }
        }
    }
}
