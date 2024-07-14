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
    public partial class FConfiguracion : Form
    {
        public string fclientes { get; set; }
        public string fproductos { get; set; }
        public string fventas { get; set; }
        public FConfiguracion()
        {
            fclientes= string.Empty;
            fproductos= string.Empty;
            fventas= string.Empty;
            InitializeComponent();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            DialogResult dResult = openFileDialog1.ShowDialog(this);
            if (dResult == DialogResult.OK)
            {
               string name =  openFileDialog1.FileName;
               fclientes = name;
               labelCliente.Text = fclientes;
               //MessageBox.Show(name);
            }
            else
            {

            }
        }

        private void buttonProducto_Click(object sender, EventArgs e)
        {
            DialogResult dResult = openFileDialog1.ShowDialog(this);
            if (dResult == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
                fproductos = name;
                labelProducto.Text = fproductos;
                //MessageBox.Show(name);
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dResult = openFileDialog1.ShowDialog(this);
            if (dResult == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
                fventas = name;
                labelVenta.Text = fventas;
                //MessageBox.Show(name);
            }
            else
            {

            }
        }
    }
}
