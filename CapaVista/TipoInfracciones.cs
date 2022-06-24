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
        Controller Controller;
        public TipoInfracciones(Controller ctr)
        {
            InitializeComponent();
            Controller = ctr;
            RefrescarLista();
        }

        private List<TipoInfraccion> RefrescarLista()
        {
            List<TipoInfraccion> lista = Controller.TiposInfraccion;

            listBoxTipoInfraccion.Items.Clear();

            for (int i = 0; i < lista.Count; i++)
                listBoxTipoInfraccion.Items.Add(lista.ToString());

            return lista;
        }

        private void buttonAgregarTipoInfraccion_Click(object sender, EventArgs e)
        {
            AgregarTipoInfraccion form = new AgregarTipoInfraccion(Controller);
            form.ShowDialog();
            RefrescarLista();
        }

        private void buttonModificarTipoInfraccion_Click(object sender, EventArgs e)
        {
            ModificarTipoInfraccion form = new ModificarTipoInfraccion(Controller, (TipoInfraccion)listBoxTipoInfraccion.SelectedItem);
            form.ShowDialog();
            RefrescarLista();
        }
    }
}
