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
        Vehiculo Vehiculo;
        bool primeraSeleccion;
        public RegistrarPago()
        {
            InitializeComponent();

            listBoxVehiculos.DataSource = null;
            primeraSeleccion = true;
            listBoxVehiculos.DataSource = Vehiculo.GetVehiculos();
            listBoxVehiculos.ClearSelected();
        }

        private void RefrescarListaInfracciones()
        {
            Vehiculo = (Vehiculo)listBoxVehiculos.SelectedItem;
            List<Infraccion> infracciones = new List<Infraccion>();

            if(Vehiculo != null)
                infracciones = Vehiculo.GetInfraccionesPendientes();

            checkedListBoxInfraccion.Items.Clear();

            //Muestra las infracciones de los duenios que no estan pagas
            for (int i = 0; i < infracciones.Count; i++)
                checkedListBoxInfraccion.Items.Add(infracciones[i]);
        }
        private void listBoxVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (primeraSeleccion)
            {
                listBoxVehiculos.ClearSelected();
                primeraSeleccion = false;
            }

            Vehiculo = (Vehiculo)listBoxVehiculos.SelectedItem;
            RefrescarListaInfracciones();

            if (Vehiculo != null && Vehiculo.GetInfraccionesPendientes().Count == 0)
                MessageBox.Show("Este vehiculo no tiene infracciones pendientes", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRegistrarPagos_Click(object sender, EventArgs e)
        {
            List<Infraccion> infracciones = new List<Infraccion>();

            for (int i = 0; i < checkedListBoxInfraccion.CheckedItems.Count; i++)
                 infracciones.Add((Infraccion)checkedListBoxInfraccion.CheckedItems[i]);

            for(int i = 0; i < infracciones.Count; i++)
            {
                infracciones[i].RegistrarPago(dateTimePickerFechaPago.Value);
                infracciones[i].Actualizar();
            }

            RefrescarListaInfracciones();
            listBoxVehiculos.ClearSelected();
        }
    }
}
