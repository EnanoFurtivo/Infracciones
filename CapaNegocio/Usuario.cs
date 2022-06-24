using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public abstract class Usuario : IDatos
    {
        //Lista estatica de usuarios//
        public static List<Usuario> Usuarios;
        public static bool RecuperarUsuarios()
        {
            DatosBD.Recuperar();
        }
        public static List<Usuario> GetUsuarios(Type filterType)
        {
            List<Usuario> result = new List<Usuario>();

            foreach (var u in Usuarios)
                if (u.GetType() == filterType)
                    result.Add(u);

            return result;
        }
        
        //Atributos de un usuario//
        public int Dni { get; internal set; }
        public string Clave { get; internal set; }
        public string Nombre { get; internal set; }

        //Constructor//
        public Usuario(int dni, string clave, string nombre)
        {
            this.Dni = dni;
            this.Clave = clave ?? throw new ArgumentNullException(nameof(clave));
            this.Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
        }

        //Registrar, actualizar y/o eliminar el objeto de la persistencia//
        public abstract bool Registrar();
        public abstract bool Actualizar();
        public abstract bool Eliminar();
    }
}
