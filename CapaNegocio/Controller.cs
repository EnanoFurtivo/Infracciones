using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Controller
    {
        public List<TipoInfraccion> TiposInfraccion;
        public List<Usuario> Usuarios;

        public Controller()
        {
            TiposInfraccion = new List<TipoInfraccion>();
            Usuarios = new List<Usuario>();
        }

        public void RegistrarTipoInfraccion()
        {
            throw new NotImplementedException();
        }

        public void RegistrarInfraccion(Infraccion infraccion)
        {
            throw new NotImplementedException();
        }

        public void RegistrarTipoInfraccion(TipoInfraccion tipoInfraccion)
        {
            throw new NotImplementedException();
        }

        public void EliminarInfraccion(Infraccion infraccion)
        {
            throw new NotImplementedException();
        }

        public void ModificarTipoInfraccion(TipoInfraccion tipoInfraccion)
        {
            throw new NotImplementedException();
        }
    }
}
