using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Duenio : Usuario
    {
        public List<Vehiculo> Vehiculos { get; internal set; }

        public Duenio(int dni, string clave, string nombre) : base(dni, clave, nombre)
        {
            Vehiculos = new List<Vehiculo>();
        }

        public void RegistrarVehiculo(Vehiculo vehiculo)
        {
            if (vehiculo == null)
                throw new ArgumentNullException(nameof(vehiculo));

            Vehiculos.Add(vehiculo);
        }
        public void EliminarVehiculo(Vehiculo vehiculo)
        {
            if (vehiculo == null)
                throw new ArgumentNullException(nameof(vehiculo));

            Vehiculos.Remove(vehiculo);
        }
        public override List<Infraccion> MostrarLista()
        {
            List<Infraccion> lista = new List<Infraccion>();

            for(int i = 0; i < Vehiculos.Count; i++)
                for(int j = 0; i < Vehiculos[i].Infracciones.Count; j++)
                    lista.Add(Vehiculos[i].Infracciones[j]);

            return lista;
        }
    }
}
