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
    public partial class RegistroInfraccion : Form
    {
        Controller controller;
        public RegistroInfraccion(Controller ctr)
        {
            InitializeComponent();
            controller = ctr;

            comboBoxTipoInfraccion.Items.Clear();
            for(int i = 0; i < controller.TiposInfraccion.Count; i++)
                comboBoxTipoInfraccion.Items.Add(controller.TiposInfraccion[i].ToString());

            List<Usuario> usuarios = controller.Usuarios;
            List<Duenio> duenios = new List<Duenio>();

            for(int i = 0;i < usuarios.Count; i++)
                if(usuarios[i].GetType() == typeof(Duenio))
                    duenios.Add((Duenio)usuarios[i]);


            comboBoxVehiculo.Items.Clear();
            for(int i = 0; i < duenios.Count; i++)
                for(int j = 0; j < duenios[i].Vehiculos.Count; j++)
                    comboBoxVehiculo.Items.Add(duenios[i].Vehiculos[j].ToString());
        }

        private void buttonRegistrarInfraccion_Click(object sender, EventArgs e)
        {
            TipoInfraccion tipoInfraccion = (TipoInfraccion)comboBoxTipoInfraccion.SelectedItem;
            Vehiculo vehiculo = (Vehiculo)comboBoxVehiculo.SelectedItem;
            DateTime dateTime = dateTimePickerFechaInfraccion.Value;

            if(dateTime != null && tipoInfraccion != null && vehiculo != null)
            {
                Infraccion infraccion = new Infraccion(dateTime, tipoInfraccion, vehiculo);
                controller.RegistrarInfraccion(infraccion);
            }
        }
    }
}
