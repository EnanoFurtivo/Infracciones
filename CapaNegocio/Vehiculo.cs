using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Vehiculo
    {
        public string Dominio { get; internal set; }
        public Duenio Duenio { get; internal set; }
        public string Marca { get; internal set; }
        public List<Infraccion> Infracciones { get; internal set; }

        public Vehiculo(string dominio, Duenio duenio, string marca, List<Infraccion> infracciones)
        {
            Dominio = dominio ?? throw new ArgumentNullException(nameof(dominio));
            Duenio = duenio ?? throw new ArgumentNullException(nameof(duenio));
            Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            Infracciones = new List<Infraccion>();
            Duenio.RegistrarVehiculo(this);
        }

        public void Modificar(string dominio, Duenio duenio, string marca)
        {
            Dominio = dominio ?? Dominio;
            Marca = marca ?? Marca;

            if (duenio != null)
            {
                Duenio.EliminarVehiculo(this);
                duenio.RegistrarVehiculo(this);
                Duenio = duenio;
            }
        }
        public void RegistrarInfraccion(TipoInfraccion tipoInfraccion, DateTime fechaVencimiento)
        {
            if (tipoInfraccion == null)
                throw new ArgumentNullException(nameof(tipoInfraccion));

            Infracciones.Add(new Infraccion(fechaVencimiento, tipoInfraccion, this));
        }
        public void EliminarInfraccion(Infraccion infraccion)
        {
            if (infraccion == null)
                throw new ArgumentNullException(nameof(infraccion));

            Infracciones.Remove(infraccion);
        }
        public static List<Vehiculo> GetVehiculos()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            List<Usuario> duenios = Usuario.GetUsuarios(typeof(Duenio));

            for (int i = 0; i < duenios.Count; i++)
            {
                Duenio duenio = (Duenio)duenios[i];
                for (int j = 0; j < duenio.Vehiculos.Count; j++)
                {
                    Vehiculo vehiculo = duenio.Vehiculos[j];
                    lista.Add(vehiculo);
                }
            }

            return lista;
        }
        public List<Infraccion> GetInfraccionesPendientes()
        {
            List<Infraccion> lista = new List<Infraccion>();

            for (int i = 0; i < Infracciones.Count; i++)
                if (!Infracciones[i].EstaPaga())
                    lista.Add(Infracciones[i]);

            return lista;
        }
    }
}
