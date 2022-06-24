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

            comboBoxTipoInfraccion.Items.Clear();
            for(int i = 0; i < TipoInfraccion.TiposInfraccion.Count; i++)
                comboBoxTipoInfraccion.Items.Add(TipoInfraccion.TiposInfraccion[i].ToString());

            comboBoxVehiculo.Items.Clear();
            for(int i = 0; i < Vehiculo.GetVehiculos().Count; i++)
                comboBoxVehiculo.Items.Add(Vehiculo.GetVehiculos().ToString());
        }

        private void buttonRegistrarInfraccion_Click(object sender, EventArgs e)
        {
            TipoInfraccion tipoInfraccion = (TipoInfraccion)comboBoxTipoInfraccion.SelectedItem;
            Vehiculo vehiculo = (Vehiculo)comboBoxVehiculo.SelectedItem;
            DateTime dateTime = dateTimePickerFechaInfraccion.Value;

            if(dateTime != null && tipoInfraccion != null && vehiculo != null)
                vehiculo.RegistrarInfraccion(tipoInfraccion, dateTime);
        }
    }
}
