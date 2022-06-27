using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Duenio : Usuario
    {
        //Lista de vehiculos//
        public List<Vehiculo> Vehiculos { get; set; }
        public void RecuperarVehiculos()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            
            List<Dictionary<string, string>> datosVehiculos = DatosBD.Recuperar(
                "vehiculo",                                 //FROM vehiculo
                new string[]  {"dominio","marca"},          //SELECT dominio, marca
                new Dictionary<string, object> {{"duenio",Dni}}   //WHERE duenio = Dni
                );

            foreach (Dictionary<string, string> datosUsuario in datosVehiculos)
            {
                string dominio = datosUsuario["dominio"];
                string marca = datosUsuario["marca"];

                Vehiculo vehiculo = new Vehiculo(dominio, this, marca);
                vehiculo.RecuperarInfracciones();

                vehiculos.Add(vehiculo);
            }

            Vehiculos = vehiculos;
        }

        //Constructor//
        public Duenio(int dni, string clave, string nombre) : base(dni, clave, nombre)
        {
            Vehiculos = new List<Vehiculo>();
        }
        //Registrar, actualizar y/o eliminar el objeto de la persistencia//
        public override void Registrar()
        {
            throw new NotImplementedException();
        }
        public override void Actualizar()
        {
            throw new NotImplementedException();
        }
        public override void Eliminar()
        {
            throw new NotImplementedException();
        }
    }
}
