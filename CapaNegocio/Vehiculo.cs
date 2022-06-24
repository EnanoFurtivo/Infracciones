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
        //Obtener todos los vehiculos//
        public static List<Vehiculo> GetVehiculos()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            List<Usuario> duenios = Usuario.GetUsuarios(typeof(Duenio));

            for (int i = 0; i < duenios.Count; i++)
            {
                Duenio duenio = (Duenio)duenios[i];
                for (int j = 0; j < duenio.Vehiculos.Count; j++)
                    vehiculos.Add(duenio.Vehiculos[j]);
            }

            return vehiculos;
        }

        //Lista de infracciones//
        public List<Infraccion> Infracciones { get; internal set; }
        public void RecuperarInfracciones()
        {
            List<Infraccion> infracciones = new List<Infraccion>();

            List<Dictionary<string, string>> datosInfracciones = DatosBD.Recuperar(
                "infraccion",                                       //FROM infraccion
                new string[]  {"fechaInfraccion","tipoInfraccion"}, //SELECT fechaInfraccion, tipoInfraccion
                new string[,] {{"vehiculo",Dominio}}                //WHERE vehiculo = <Dominio>
                );

            foreach (Dictionary<string, string> datosInfraccion in datosInfracciones)
            {
                DateTime fechaInfraccion = DateTime.Parse(datosInfraccion["fechaInfraccion"]);
                int nroTipoInfraccion = int.Parse(datosInfraccion["tipoInfraccion"]);
                TipoInfraccion tipoInfraccion = TipoInfraccion.GetTipoInfraccion(nroTipoInfraccion);

                Infraccion infraccion = new Infraccion(fechaInfraccion, tipoInfraccion, this);
                
                infracciones.Add(infraccion);
            }

            Infracciones = infracciones;
        }
        
        //Atributos del vehiculo//
        public string Dominio { get; internal set; }
        public Duenio Duenio { get; set; }
        public string Marca { get; internal set; }
        
        //Constructor//
        public Vehiculo(string dominio, Duenio duenio, string marca)
        {
            Dominio = dominio ?? throw new ArgumentNullException(nameof(dominio));
            Duenio = duenio ?? throw new ArgumentNullException(nameof(duenio));
            Marca = marca ?? throw new ArgumentNullException(nameof(marca));
            Infracciones = new List<Infraccion>();
        }

        //Metodos del vehiculo//
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

        //Persistencia de datos//
        public bool Registrar()
        {
            throw new InvalidOperationException();
        }
        public bool Actualizar()
        {
            throw new InvalidOperationException();
        }
        public bool Eliminar()
        {
            throw new InvalidOperationException();
        }
    }
}
