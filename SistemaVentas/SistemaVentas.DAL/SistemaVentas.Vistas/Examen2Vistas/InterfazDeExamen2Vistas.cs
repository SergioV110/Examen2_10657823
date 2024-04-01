using SistemaVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Vistas.Examen2Vistas
{
    public partial class InterfazDeExamen2Vistas : Form
    {
        public InterfazDeExamen2Vistas()
        {
            InitializeComponent();
        }

        private void InterfazDeExamen2Vistas_Load(object sender, EventArgs e)
        {

        }

        private void buttonIngresosProveedores_Click(object sender, EventArgs e)
        {
            ProveedorBss bss = new ProveedorBss();
            dataGridView1.DataSource = bss.ProovedorTLINBss();
        }

        private void buttonNombreyApellidoCliente_Click_1(object sender, EventArgs e)
        {
            ClienteBss bss = new ClienteBss();
            dataGridView1.DataSource = bss.ClienteNyABss();
        }

        private void buttonMarcaMasVendida_Click(object sender, EventArgs e)
        {
            MarcaBss bss = new MarcaBss();
            dataGridView1.DataSource = bss.MarcaNmasVBss();
        }

        private void buttonTotalProductos_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            dataGridView1.DataSource = bss.ProductoTPIBss();
        }

        private void buttonProductosVendidosVendedores_Click(object sender, EventArgs e)
        {
            RolBss bss = new RolBss();
            dataGridView1.DataSource = bss.RolNPVVBss();
        }
    }
}
