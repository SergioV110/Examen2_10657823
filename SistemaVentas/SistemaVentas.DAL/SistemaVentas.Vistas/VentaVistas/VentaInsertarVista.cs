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

namespace SistemaVentas.Vistas.VentaVistas
{
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void VentaInsertarVista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venta v = new Venta();
            v.IdCliente = Convert.ToInt32(textBox1.Text);
            v.IdVendedor = Convert.ToInt32(textBox2.Text);
            v.Fecha = dateTimePicker1.Value;
            v.Total = Convert.ToDecimal(textBox3.Text);

            bss.InsertarVentaBss(v);
            MessageBox.Show("Se guardo correctamente la venta");
        }
    }
}
