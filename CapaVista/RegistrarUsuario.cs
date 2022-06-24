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
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void buttonRegistrarDuenio_Click(object sender, EventArgs e)
        {
            string dniStr = textBoxDni.Text;
            int dni;
            if (!ValidarDni(dniStr, out dni))
                return;

            string nombre = textBoxNombre.Text;
            if (!ValidarNombre(nombre))
                return;

            string clave = textBoxClave.Text;
            if (!ValidarClave(clave))
                return;

            Duenio duenio = new Duenio(dni, clave, nombre);

            ;//Usuario.RegistrarUsuario(duenio);
        }

        //Validar//
        private bool ValidarNombre(string nombre)
        {
            if (nombre == "")
            {
                MessageBox.Show("Se esperaba un nombre", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private bool ValidarClave(string clave)
        {
            if (clave == "")
            {
                MessageBox.Show("Se esperaba una clave", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private bool ValidarDni(string dniStr, out int dni)
        {
            if (dniStr == "")
            {
                MessageBox.Show("Se esperaba un dni", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dni = -1;
                return false;
            }

            if (!int.TryParse(dniStr, out dni))
            {
                MessageBox.Show("El dni debe ser numerico", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dni = -1;
                return false;
            }

            return true;
        }
    }
}
