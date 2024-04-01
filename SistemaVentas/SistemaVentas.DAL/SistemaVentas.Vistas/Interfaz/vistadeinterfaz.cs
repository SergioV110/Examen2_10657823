using SistemaVentas.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Vistas.Interfaz
{
    public partial class vistadeinterfaz : Form
    {
        public vistadeinterfaz()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vistadeinterfaz_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }
        private Form activeform = null;
        private void abrirformulariohijo(Form hijo)
        {
            if (activeform != null)
                activeform.Close();
            activeform = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panelhijo.Controls.Add(hijo);
            panelhijo.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new SesionGerente());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new SesionVendedor());
        }
    }
}
