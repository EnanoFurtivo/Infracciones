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
            //Carga las listas para las infracciones
            List<Usuario> usuarios = Controller.Usuarios;
            List<Infraccion> lista = new List<Infraccion>();

            for (int i = 0; i < usuarios.Count; i++)
                for (int j = 0; j < usuarios[i].MostrarLista().Count; j++)
                    lista.Add(usuarios[i].MostrarLista()[j]);

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
