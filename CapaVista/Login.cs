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
        public Login()
        {
            InitializeComponent();

            //Recupera las listas al comenzar la ejecucion.
            Usuario.Recuperar();
            TipoInfraccion.Recuperar();
        }
    }
}
