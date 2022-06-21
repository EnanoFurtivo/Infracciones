using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void AbrirForm(object form)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frm);
            this.panelContenedor.Tag = frm;
            frm.Show();
        }

        private void buttonFormInfraccion_Click(object sender, EventArgs e)
        {
            AbrirForm(new Infraccion());
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void buttonFormRegistroInfraccion_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistroInfraccion());
        }

        private void buttonFormRegistrarPago_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarPago());
        }
    }
}
