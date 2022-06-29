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
    public partial class RegistrarVehiculo : Form
    {
        public RegistrarVehiculo()
        {
            InitializeComponent();

            comboBoxDuenios.DataSource = null;
            comboBoxDuenios.DataSource = Usuario.GetUsuarios(typeof(Duenio));
        }

        private void buttonRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            string dominio = textBoxDominio.Text;
            if (!ValidarDominio(dominio))
                return;

            string marca = textBoxMarca.Text;
            if (!ValidarMarca(marca))
                return;

            if (comboBoxDuenios.SelectedItem != null)
            {
                Vehiculo vehiculo = new Vehiculo(dominio, (Duenio)comboBoxDuenios.SelectedItem, marca);
                vehiculo.Registrar();
                MessageBox.Show("Vehiculo registrado con exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Validar//
        private bool ValidarDominio(string dominio)
        {
            if (dominio == "")
            {
                MessageBox.Show("Se esperaba un dominio", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private bool ValidarMarca(string marca)
        {
            if (marca == "")
            {
                MessageBox.Show("Se esperaba una marca", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
