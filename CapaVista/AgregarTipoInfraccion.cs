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
    public partial class AgregarTipoInfraccion : Form
    {
        Controller Controller;
        public AgregarTipoInfraccion(Controller ctr)
        {
            InitializeComponent();
            Controller = ctr;

            string grave = "Grave";
            string leve = "Leve";

            comboBoxTipo.DataSource = null;
            comboBoxTipo.Items[0] = grave;
            comboBoxTipo.Items[1] = leve;
        }

        private void buttonAgregarTipoInfraccion_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(textBoxCodigo.Text);
            string descripcion = textBoxDescripcion.Text;
            double importe = double.Parse(textBoxImporte.Text);
            string tipo = comboBoxTipo.SelectedItem.ToString();

            TipoInfraccion tipoInfraccion = new TipoInfraccion(codigo, descripcion, importe, tipo);
            Controller.RegistrarTipoInfraccion(tipoInfraccion);
        }
    }
}
