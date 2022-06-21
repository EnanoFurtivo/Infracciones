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
        Controller Controller;
        public RegistrarPago(Controller ctr)
        {
            InitializeComponent();
            Controller = ctr;
            RefrescarLista();
        }

        private List<Infraccion> RefrescarLista()
        {
            List<Infraccion> lista = Controller.Usuarios.Vehiculos.Infracciones);

            checkedListBoxInfraccion.Items.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                if(lista[i].FechaPago == null)
                    checkedListBoxInfraccion.Items.Add(lista.ToString());
            }

            return lista;
        }

        private void checkedListBoxInfraccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Infraccion item = (Infraccion)checkedListBoxInfraccion.GetItemChecked;
            item.SetFechaPago(DateTime.Now);
            RefrescarLista();
        }
    }
}
