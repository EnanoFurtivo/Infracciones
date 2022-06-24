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

            for (int i = 0; i < Usuario.GetUsuarios(typeof(Duenio)).Count; i++)
                comboBoxDuenios.Items.Add(Usuario.GetUsuarios(typeof(Duenio))[i]);
        }

        private void buttonRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            string dominio = textBoxDominio.Text;
            if (!ValidarDominio(dominio))
                return;

            string marca = textBoxMarca.Text;
            if (!ValidarMarca(marca))
                return;

            Duenio duenio = (Duenio)comboBoxDuenios.SelectedItem;

            if (duenio != null)
            {
                Vehiculo vehiculo = new Vehiculo(dominio, duenio, marca);
                duenio.Vehiculos.Add(vehiculo);
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
