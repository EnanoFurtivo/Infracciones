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
    public partial class TipoInfracciones : Form
    {
        public TipoInfracciones()
        {
            InitializeComponent();
            MostrarLista();
        }

        private void MostrarLista()
        {
            listBoxTipoInfraccion.Items.Clear();

            for (int i = 0; i < TipoInfraccion.TiposInfraccion.Count; i++)
                listBoxTipoInfraccion.Items.Add(TipoInfraccion.TiposInfraccion.ToString());
        }

        private void buttonAgregarTipoInfraccion_Click(object sender, EventArgs e)
        {
            AgregarTipoInfraccion form = new AgregarTipoInfraccion();
            form.ShowDialog();
            MostrarLista();
        }

        private void buttonModificarTipoInfraccion_Click(object sender, EventArgs e)
        {
            ModificarTipoInfraccion form = new ModificarTipoInfraccion((TipoInfraccion)listBoxTipoInfraccion.SelectedItem);
            form.ShowDialog();
            MostrarLista();
        }
    }
}
