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

namespace SistemaVentas.Vistas.ClienteVistas
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void ClienteInsertarVista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.IdPersona = Convert.ToInt32(textBox4.Text);
            c.TipoCliente = textBox1.Text;
            c.CodigoCliente = textBox2.Text;
            c.Estado = textBox3.Text;

            bss.InsertarClienteBss(c);
            MessageBox.Show("Se a guardo correctamente el cliente");
        }

    }
}
