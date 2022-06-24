using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public abstract class Usuario
    {
        public static List<Usuario> Usuarios;
        public int Dni { get; internal set; }
        public string Clave { get; internal set; }
        public string Nombre { get; internal set; }

        public Usuario(int dni, string clave, string nombre)
        {
            this.Dni = dni;
            this.Clave = clave ?? throw new ArgumentNullException(nameof(clave));
            this.Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
        }
        public static List<Usuario> GetUsuarios(Type filterType)
        {
            List<Usuario> result = new List<Usuario>();

            foreach (var u in Usuarios)
                if (u.GetType() == filterType)
                    result.Add(u);

            return result;
        }
    }
}
