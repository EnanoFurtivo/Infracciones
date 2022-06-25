using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaVista
{
    public partial class Inicio : Form
    {
        public Inicio(Administrador adm)
        {
            InitializeComponent();
            panelSubMenuInfracciones.Visible = false;
            buttonRegistrarUsuario.Location = new Point(0, 317);
            buttonRegistrarVehiculo.Location = new Point(0, 377);
            buttonFormRegistrarPago.Location = new Point(0, 437);
            buttonCerrarSesion.Location = new Point(0, 499);

            Administrador Admin = adm;
            this.labelBienvenida.Text = "Bienvenido/a de nuevo, " + Admin.Nombre.ToString();
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
            AbrirForm(new TipoInfracciones());
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void buttonFormRegistroInfraccion_Click(object sender, EventArgs e)
        {
            if (panelSubMenuInfracciones.Visible == true)
            {
                panelSubMenuInfracciones.Visible = false;
                buttonRegistrarUsuario.Location = new Point(0, 317);
                buttonRegistrarVehiculo.Location = new Point(0, 377);
                buttonFormRegistrarPago.Location = new Point(0, 437);
                buttonCerrarSesion.Location = new Point(0, 499);
            }
            else
            {
                panelSubMenuInfracciones.Visible = true;
                buttonRegistrarUsuario.Location = new Point(0, 352);
                buttonRegistrarVehiculo.Location = new Point(0, 407);
                buttonFormRegistrarPago.Location = new Point(0, 459);
                buttonCerrarSesion.Location = new Point(0, 512);
            }
        }

        private void buttonFormRegistrarPago_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarPago());
        }

        private void buttonRegistrarInfraccion_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistroInfraccion());
            this.buttonEliminarInfraccion.Visible = false;
            this.buttonRegistrarInfraccion.Visible = false;
        }

        private void buttonEliminarInfraccion_Click(object sender, EventArgs e)
        {
            AbrirForm(new EliminarInfraccion());
            this.buttonEliminarInfraccion.Visible = false;
            this.buttonRegistrarInfraccion.Visible = false;
        }

        private void buttonRegistrarUsuario_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarUsuario());
        }

        private void buttonRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistrarVehiculo());
        }
    }
}
