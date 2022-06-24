using System;
using System.Collections;
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
    public partial class ModificarTipoInfraccion : Form
    {
        Controller Controller;
        public ModificarTipoInfraccion(Controller ctr, TipoInfraccion tipoInf)
        {
            InitializeComponent();
            Controller = ctr;

            string grave = "Grave";
            string leve = "Leve";

            textBoxCodigo.Text = tipoInf.Codigo.ToString();
            textBoxDescripcion.Text = tipoInf.Descripcion;
            textBoxImporte.Text = tipoInf.Importe.ToString();

            comboBoxTipo.DataSource = null;
            comboBoxTipo.Items[0] = grave;
            comboBoxTipo.Items[1] = leve;
            comboBoxTipo.SelectedItem = tipoInf.Tipo;
        }

        private void buttonModificarTipoInfraccion_Click(object sender, EventArgs e)
        {
            string descripcion = textBoxDescripcion.Text;
            double importe = double.Parse(textBoxImporte.Text);
            char tipo = char.Parse(comboBoxTipo.SelectedItem.ToString());

            TipoInfraccion tipoInfraccion = new TipoInfraccion(descripcion, importe, tipo);
            Controller.ModificarTipoInfraccion(tipoInfraccion);
        }
    }
}
