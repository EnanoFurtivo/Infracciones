using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Administrador : Usuario
    {
        public Administrador(int dni, string clave, string nombre) : base(dni, clave, nombre) 
        {
        }

        public override void Actualizar()
        {
            throw new NotImplementedException();
        }
        public override void Eliminar()
        {
            throw new NotImplementedException();
        }
        public override void Registrar()
        {
            DatosBD.Registrar(
                "usuario",
                new Dictionary<string, object> { { "dni", Dni }, { "clave", Clave }, { "nombre", Nombre }, { "discriminador", "Duenio" } }
                );
        }
    }
}
