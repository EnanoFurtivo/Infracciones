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
        public ModificarTipoInfraccion(TipoInfraccion tipoInf)
        {
            InitializeComponent();

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
            if (!ValidarDescripcion(descripcion))
                return;

            string importeStr = textBoxImporte.Text;
            double importe;
            if (!ValidarImporte(importeStr, out importe))
                return;

            char tipo = char.Parse(comboBoxTipo.SelectedItem.ToString());

            if (comboBoxTipo.SelectedItem != null)
                ;//TipoInfraccion.Actualizar(descripcion, importe, tipo);
            
            this.Close();
        }
        //Validar//
        private bool ValidarDescripcion(string descripcion)
        {
            if (descripcion == "")
            {
                MessageBox.Show("Se esperaba una descripcion", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private bool ValidarImporte(string importeStr, out double importe)
        {
            if (importeStr == "")
            {
                MessageBox.Show("Se esperaba un costo", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                importe = -1;
                return false;
            }

            if (!double.TryParse(importeStr, out importe))
            {
                MessageBox.Show("El costo debe ser numerico", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                importe = -1;
                return false;
            }

            return true;
        }
    }
}
