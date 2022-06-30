using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;

namespace UIWeb
{
    public partial class InicioSesion: System.Web.UI.Page
    {
        static string LugarBase;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(LugarBase == null)
                {
                    //path pdfs//
                    string pathAuxPdfs = Server.MapPath("/InicioSesion.aspx");
                    string[] pathPdfs = pathAuxPdfs.Split('\\');
                    pathPdfs[pathPdfs.Length - 1] = "exports";
                    string pathFinalPdfs = "";
                    foreach (string s in pathPdfs)
                        pathFinalPdfs += s + "\\";
                    Session["path_pdf"] = pathFinalPdfs;

                    //path logo//
                    string pathAuxLogo = Server.MapPath("/InicioSesion.aspx");
                    string[] pathLogo = pathAuxPdfs.Split('\\');
                    pathLogo[pathLogo.Length - 1] = "";
                    string pathFinalLogo = "";
                    for(int i = 0; i < pathLogo.Length-1; i++)
                        pathFinalLogo += pathLogo[i] + "\\";
                    Session["path_logo"] = pathFinalLogo + "logoinfracciones.png";

                    //path access//
                    string pathAux = Server.MapPath("/InicioSesion.aspx");
                    string[] path = pathAux.Split('\\');
                    path[path.Length - 1] = "bin";
                    path[path.Length - 2] = "CapaVista";
                    string pathFinal = "";
                    foreach (string s in path)
                        pathFinal += s + "\\";
                    pathFinal += "Debug" + "\\";
                    LugarBase = pathFinal;

                    //Conexion a base de datos//
                    DatosBD.PonerPathBaseAccess(LugarBase);

                    //Recupera las listas al comenzar la ejecucion//
                    TipoInfraccion.RecuperarTiposInfraccion();
                    Usuario.RecuperarUsuarios();
                    Infraccion.RecuperarUltimaInfraccion();
                }
            }
        }
        private bool ValidarDni(string dniStr, out int dni)
        {
            if (dniStr == "")
            {
                LabelDeError.Text = "Se esperaba un dni";
                dni = -1;
                return false;
            }

            if (!int.TryParse(dniStr, out dni))
            {
                LabelDeError.Text = "El dni debe ser numerico";
                dni = -1;
                return false;
            }

            return true;
        }
        private bool ValidarClave(string clave)
        {
            if (clave == "")
            {
                LabelDeError.Text = "Se esperaba una clave";
                return false;
            }

            return true;
        }
        protected void ButtonIngresar_Click(object sender, EventArgs e)
        {
            string dniStr = this.TxtBoxDni.Text;
            int dni;
            if (!ValidarDni(dniStr, out dni))
                return;

            string clave = this.TxtBoxClave.Text;
            if (!ValidarClave(clave))
                return;

            if (Usuario.ValidarCredenciales(dni, clave, typeof(Duenio)) == true)
            {
                Session["usuario"] = (Duenio)Usuario.GetUsuario(dni);
                TxtBoxDni.Text = string.Empty;
                TxtBoxClave.Text = string.Empty;
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                this.LabelDeError.Text = "El dni o clave ingresada es incorrecta";
                TxtBoxDni.Text = string.Empty;
                TxtBoxClave.Text = string.Empty;
            }
        }
    }
}