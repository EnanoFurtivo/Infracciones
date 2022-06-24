using CapaDatos;
using System;
using System.Collections;
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
        public static void RecuperarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            List<Dictionary<string,string>> datosUsuarios = DatosBD.Recuperar(
                "usuario",                                      //FROM usuario
                new string[] {"dni","clave","nombre","tipo"}    //SELECT dni, clave, nombre, tipo
                );

            foreach (Dictionary<string,string> datosUsuario in datosUsuarios)
            {
                int dni = int.Parse(datosUsuario["dni"]);
                string clave = datosUsuario["clave"];
                string nombre = datosUsuario["nombre"];
                string tipo = datosUsuario["tipo"];

                Usuario usuario;
                if (tipo == "duenio")
                {
                    usuario = new Duenio(dni, clave, nombre);
                    ((Duenio)usuario).RecuperarVehiculos();
                }
                else if (tipo == "administrador")
                    usuario = new Administrador(dni, clave, nombre);
                else
                    throw new FormatException("[RecuperarUsuarios] El tipo de usuario '" + tipo + "' no esta permitido (invalido para el usuario " + nombre + ")");
               
                usuarios.Add(usuario);
            }

            Usuarios = usuarios;
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

        //Validar//
        public static Usuario GetUsuario(int dni)
        {
            return Usuarios.Find(u => u.Dni == dni);
        }
        public bool ValidarClave(string clave)
        {
            return (this.Clave == clave);
        }
        public static bool ValidarCredenciales(int dni, string clave, Type filterType)
        {
            Usuario u = null;

            if ((u = GetUsuario(dni)) == null)
                return false;

            if (!u.ValidarClave(clave))
                return false;
            
            if(u.GetType() != filterType)
                return false;

            return true;
        }

        //Registrar, actualizar y/o eliminar el objeto de la persistencia//
        public abstract bool Registrar();
        public abstract bool Actualizar();
        public abstract bool Eliminar();

        //Conexion a base de datos//
        public static void PonerPathABaseAccess(string l)
        {
            DatosBD.PonerPathBaseAccess(l);
        }
    }
}
