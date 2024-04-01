using SistemaVentas.BSS;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Vistas.DetalleVentaVistas
{
    public partial class DetalleVentaInsertarVista : Form
    {
        public DetalleVentaInsertarVista()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void DetalleVentaInsertarVista_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta dv = new DetalleVenta();
            dv.IdVenta = Convert.ToInt32(textBox1.Text);
            dv.IdProducto = Convert.ToInt32(textBox2.Text);
            dv.Cantidad = Convert.ToInt32(textBox3.Text);
            dv.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            dv.SubTotal = Convert.ToDecimal(textBox5.Text);

            bss.InsertarDetalleVentaBss(dv);
            MessageBox.Show("Se a guardo correctamente el cliente");

        }
    }
}
