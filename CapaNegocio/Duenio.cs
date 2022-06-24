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
        public List<Vehiculo> Vehiculos { get; internal set; }
        public bool RecuperarVehiculos()
        {
            DatosBD.Recuperar();
        }

        //Constructor//
        public Duenio(int dni, string clave, string nombre) : base(dni, clave, nombre)
        {
            Vehiculos = new List<Vehiculo>();
        }

        //Registrar, actualizar y/o eliminar el objeto de la persistencia//
        public override bool Registrar()
        {
            throw new NotImplementedException();
        }
        public override bool Actualizar()
        {
            throw new NotImplementedException();
        }
        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }
    }
}
