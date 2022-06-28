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
        TipoInfraccion TipoInfraccion;
        public ModificarTipoInfraccion(TipoInfraccion tipoInf)
        {
            InitializeComponent();
            TipoInfraccion = tipoInf;

            List<string> listaTipo = new List<string>() { "Grave", "Leve" };

            comboBoxTipo.DataSource = null;
            comboBoxTipo.DataSource = listaTipo;

            if(tipoInf.Tipo == 'G')
                comboBoxTipo.SelectedItem = listaTipo[0];
            else if (tipoInf.Tipo == 'L')
                comboBoxTipo.SelectedItem=  listaTipo[1];

            textBoxCodigo.Text = tipoInf.Codigo.ToString();
            textBoxDescripcion.Text = tipoInf.Descripcion;
            textBoxImporte.Text = tipoInf.Importe.ToString();
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

            if (comboBoxTipo.SelectedItem != null)
            {
                string tipoStr = comboBoxTipo.SelectedItem.ToString();
                char tipo = tipoStr[0];

                TipoInfraccion.Descripcion = descripcion;
                TipoInfraccion.Importe = importe;
                TipoInfraccion.Tipo = tipo;
                TipoInfraccion.Actualizar();
            }

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
