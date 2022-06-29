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
    public partial class RegistroInfraccion : Form
    {
        public RegistroInfraccion()
        {
            InitializeComponent();

            comboBoxTipoInfraccion.DataSource = null;
            comboBoxTipoInfraccion.DataSource = TipoInfraccion.TiposInfraccion;

            comboBoxVehiculo.DataSource = null;
            comboBoxVehiculo.DataSource = Vehiculo.GetVehiculos();
        }

        private void buttonRegistrarInfraccion_Click(object sender, EventArgs e)
        {
            TipoInfraccion tipoInfraccion = (TipoInfraccion)comboBoxTipoInfraccion.SelectedItem;
            Vehiculo vehiculo = (Vehiculo)comboBoxVehiculo.SelectedItem;
            DateTime dateTime = dateTimePickerFechaInfraccion.Value;

            if(dateTime != null && tipoInfraccion != null && vehiculo != null)
            {
                vehiculo.RegistrarInfraccion(tipoInfraccion, dateTime);
                MessageBox.Show("Infraccion registrada con exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
