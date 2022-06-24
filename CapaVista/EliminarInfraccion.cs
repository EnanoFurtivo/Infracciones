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
    public partial class EliminarInfraccion : Form
    {
        public EliminarInfraccion()
        {
            InitializeComponent();
            MostrarLista();
        }
        private void MostrarLista()
        {
            //Carga las lista de las infracciones pendientes
            List<Vehiculo> vehiculos = Vehiculo.GetVehiculos();
            List<Infraccion> infracciones = new List<Infraccion>();

            for (int i = 0; i < vehiculos.Count; i++)
            {
                infracciones = vehiculos[i].GetInfraccionesPendientes();

                for (int j = 0; j < infracciones.Count; j++)
                    listBoxInfraccion.Items.Add(infracciones[j]);
            }
        }
        private void listBoxInfraccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Infraccion infraccion = (Infraccion)listBoxInfraccion.SelectedItem;

            if(listBoxInfraccion.SelectedItem != null)
            {
                Vehiculo vehiculo = infraccion.Vehiculo;
                vehiculo.EliminarInfraccion(infraccion);
            }

            MostrarLista();
        }
    }
}
