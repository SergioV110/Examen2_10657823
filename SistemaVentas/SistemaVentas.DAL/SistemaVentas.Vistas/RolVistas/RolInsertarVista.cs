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

namespace SistemaVentas.Vistas.RolVistas
{
    public partial class RolInsertarVista : Form
    {
        public RolInsertarVista()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();
        private void RolInsertarVista_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rol r = new Rol();
            r.Nombre = textBox1.Text;

            bss.InsertarRolBss(r);
            MessageBox.Show("Se a guardado correctamente el rol");

        }
    }
}
