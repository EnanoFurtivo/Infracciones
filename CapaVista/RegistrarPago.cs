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
    public partial class RegistrarPago : Form
    {
        public RegistrarPago()
        {
            InitializeComponent();
            List<Vehiculo> vehiculos = Vehiculo.GetVehiculos();

            listBoxVehiculos.Items.Clear();
            listBoxVehiculos.Items.Add(vehiculos.ToString());
        }

        private void RefrescarListaInfracciones(Vehiculo vehiculo)
        {
            List<Infraccion> infracciones = vehiculo.GetInfraccionesPendientes();

            checkedListBoxInfraccion.Items.Clear();

            //Muestra las infracciones de los duenios que no estan pagas
            for (int i = 0; i < infracciones.Count; i++)
            {
                checkedListBoxInfraccion.Items.Add(infracciones[i].ToString());
            }
        }
        private void listBoxVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehiculo vehiculo = (Vehiculo)listBoxVehiculos.SelectedItem;
            RefrescarListaInfracciones(vehiculo);
        }

        private void buttonRegistrarPagos_Click(object sender, EventArgs e)
        {
            List<Infraccion> infracciones = new List<Infraccion>();

            for (int i = 0; i < checkedListBoxInfraccion.CheckedItems.Count; i++)
                 infracciones.Add((Infraccion)checkedListBoxInfraccion.CheckedItems[i]);

            for(int i = 0; infracciones.Count > 0; i++)
                infracciones[i].RegistrarPago(dateTimePickerFechaPago.Value);
        }
    }
}
