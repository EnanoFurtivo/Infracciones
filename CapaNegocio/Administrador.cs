using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Administrador : Usuario
    {
        public Administrador(int dni, string clave, string nombre) : base(dni, clave, nombre) 
        {
        }
        public override List<Infraccion> MostrarLista()
        {
            throw new NotImplementedException();
        }
    }
}
