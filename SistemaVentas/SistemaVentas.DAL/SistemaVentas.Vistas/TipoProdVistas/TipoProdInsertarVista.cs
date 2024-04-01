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

namespace SistemaVentas.Vistas.TipoProdVistas
{
    public partial class TipoProdInsertarVista : Form
    {
        public TipoProdInsertarVista()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();
        private void TipoProdInsertarVista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TipoProd t = new TipoProd();
            t.Nombre = textBox1.Text;

            bss.InsertarTipoProdBss(t);
            MessageBox.Show("Se a guardado correctamente el tipoprod");
        }
    }
}
