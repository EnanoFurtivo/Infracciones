using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Vehiculo : IDatos
    {
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

        public string Dominio { get; internal set; }
        public Duenio Duenio { get; set; }
        public string Marca { get; internal set; }
        public List<Infraccion> Infracciones { get; internal set; }
        public bool RecuperarInfracciones()
        {

        }

        public Vehiculo(string dominio, Duenio duenio, string marca, List<Infraccion> infracciones)
        {
            Dominio = dominio ?? throw new ArgumentNullException(nameof(dominio));
            Duenio = duenio ?? throw new ArgumentNullException(nameof(duenio));
            Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            Infracciones = new List<Infraccion>();
            Duenio.RegistrarVehiculo(this);
        }

        public List<Infraccion> GetInfraccionesPendientes()
        {
            List<Infraccion> lista = new List<Infraccion>();

            for (int i = 0; i < Infracciones.Count; i++)
                if (!Infracciones[i].EstaPaga())
                    lista.Add(Infracciones[i]);

            return lista;
        }
        public void RegistrarInfraccion(TipoInfraccion tipoInfraccion, DateTime fechaInfraccion)
        {
            if (tipoInfraccion == null)
                throw new ArgumentNullException(nameof(tipoInfraccion));

            Infraccion infraccion = new Infraccion(fechaInfraccion, tipoInfraccion, this);
            Infracciones.Add(infraccion);
            infraccion.Registrar();
        }
        public void EliminarInfraccion(Infraccion infraccion)
        {
            if (infraccion == null)
                throw new ArgumentNullException(nameof(infraccion));

            infraccion.Eliminar();
            Infracciones.Remove(infraccion);
        }

        public bool Registrar()
        {
            return DatosBD.Registrar();
        }
        public bool Actualizar()
        {
            throw new InvalidOperationException();
        }
        public bool Eliminar()
        {
            return DatosBD.Eliminar();
        }
    }
}
