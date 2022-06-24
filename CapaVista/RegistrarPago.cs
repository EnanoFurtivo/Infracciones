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
            //Carga las listas para las infracciones
            List<Usuario> usuarios = Controller.Usuarios;
            List<Infraccion> lista = new List<Infraccion>();

            for(int i = 0; i < usuarios.Count; i++)
                for(int j = 0; j < usuarios[i].MostrarLista().Count; j++)
                    lista.Add(usuarios[i].MostrarLista()[j]);


            checkedListBoxInfraccion.Items.Clear();

            //Muestra las infracciones de los duenios que no estan pagas
            for (int i = 0; i < lista.Count; i++)
            {
                if(lista[i].FechaPago == null)
                    checkedListBoxInfraccion.Items.Add(lista.ToString());
            }

            return lista;
        }

        private void checkedListBoxInfraccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool seleccionado = false;
            seleccionado = checkedListBoxInfraccion.GetItemChecked(checkedListBoxInfraccion.SelectedIndex);

            if (seleccionado)
            {
                Infraccion item = (Infraccion)checkedListBoxInfraccion.SelectedItem;
                item.FechaPago = DateTime.Now;
            }

            RefrescarLista();
        }
    }
}
