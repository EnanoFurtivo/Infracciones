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
        Controller Controller;
        public EliminarInfraccion(Controller ctr)
        {
            InitializeComponent();
            Controller = ctr;
            RefrescarLista();
        }
        private List<Infraccion> RefrescarLista()
        {
            List<Infraccion> lista = Controller.Usuarios.Vehiculos.Infracciones);

            listBoxInfraccion.Items.Clear();

            for (int i = 0; i < lista.Count; i++)
                listBoxInfraccion.Items.Add(lista.ToString());

            return lista;
        }

        private void listBoxInfraccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Infraccion infraccion = (Infraccion)listBoxInfraccion.SelectedItem;
            Controller.EliminarInfraccion(infraccion);
            RefrescarLista();
        }
    }
}
