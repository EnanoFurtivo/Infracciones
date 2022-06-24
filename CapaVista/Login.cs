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
    public partial class Login : Form
    {
        static string LugarBase;
        public Login()
        {
            InitializeComponent();

            //Conexion a base de datos//
            LugarBase = Application.StartupPath;
            Usuario.PonerPathABaseAccess(LugarBase);

            //Recupera las listas al comenzar la ejecucion//
            Usuario.RecuperarUsuarios();
            TipoInfraccion.RecuperarTiposInfraccion();
        }

        //Validar//
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
        private bool ValidarClave(string clave)
        {
            if (clave == "")
            {
                MessageBox.Show("Se esperaba una clave", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        //Acceder//
        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            string dniStr = textBoxDni.Text;
            int dni;
            if (!ValidarDni(dniStr, out dni))
                return;

            string clave = textBoxClave.Text;
            if (!ValidarClave(clave))
                return;

            if (Usuario.ValidarCredenciales(dni, clave, typeof(Administrador)))
            {
                Inicio form = new Inicio((Administrador)Usuario.GetUsuario(dni));
                form.ShowDialog();
            }
            else
                MessageBox.Show("El dni o clave ingresada es incorrecta", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
