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
                "infraccion",                                                       //FROM infraccion
                new string[]  {"numInfraccion","fechaInfraccion","fechaVencimiento", "fechaPago", "tipoInfraccion", "importeBase", "montoInfraccion" }, //SELECT numInfraccion, fechaInfraccion, tipoInfraccion...
                new Dictionary<string, object> {{"vehiculo",Dominio}}                                //WHERE vehiculo = <Dominio>                                 
                );

            foreach (Dictionary<string, string> datosInfraccion in datosInfracciones)
            {
                int numInfraccion = int.Parse(datosInfraccion["numInfraccion"]);
                DateTime fechaInfraccion = DateTime.Parse(datosInfraccion["fechaInfraccion"]);
                DateTime fechaVencimiento = DateTime.Parse(datosInfraccion["fechaVencimiento"]);
                DateTime? fechaPago = (datosInfraccion["fechaPago"] != "") ? (DateTime?)DateTime.Parse(datosInfraccion["fechaPago"]) : null;
                int nroTipoInfraccion = int.Parse(datosInfraccion["tipoInfraccion"]);
                TipoInfraccion tipoInfraccion = TipoInfraccion.GetTipoInfraccion(nroTipoInfraccion);
                double importeBase = double.Parse(datosInfraccion["importeBase"]);
                double montoInfraccion = double.Parse(datosInfraccion["montoInfraccion"]);

                Infraccion infraccion = new Infraccion(numInfraccion, fechaInfraccion, fechaVencimiento, fechaPago, tipoInfraccion, this, importeBase, montoInfraccion);
                
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
        public List<Infraccion> GetInfraccionesPagas()
        {
            List<Infraccion> lista = new List<Infraccion>();

            for (int i = 0; i < Infracciones.Count; i++)
                if (Infracciones[i].EstaPaga())
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
        public override string ToString()
        {
            return Dominio + " - " + Duenio.Nombre + " - " + Marca;
        }

        //Persistencia de datos//
        public void Registrar()
        {
            DatosBD.Registrar(
                "vehiculo",
                new Dictionary<string, object> {{"dominio",Dominio},{"marca",Marca},{"duenio",Duenio.Dni}}
                );
        }
        public void Actualizar()
        {
            throw new InvalidOperationException();
        }
        public void Eliminar()
        {
            throw new InvalidOperationException();
        }
    }
}
