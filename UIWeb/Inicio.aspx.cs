using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace UIWeb
{
    public partial class Inicio : System.Web.UI.Page
    {
        static protected List<Infraccion> Infracciones;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Duenio usr = (Duenio)Session["usuario"];
                Infracciones = usr.GetAllInfraccionesPendientes();
                refrescarLista(Infracciones, ListBoxInfracciones);
                refrescarLista(usr.GetAllInfraccionesPagas(), ListBoxInfraccionesPagas);
                this.LabelBienvenida.Text = "Bienvenido/a de nuevo " + usr.Nombre;
            }
        }

        public void refrescarLista(List<Infraccion> infracciones, ListBox listBox)
        {
            Infracciones = infracciones;
            listBox.Items.Clear();
            for(int i=0;i<infracciones.Count; i++)
                listBox.Items.Add(infracciones[i].ToString());
        }

        protected void ButtonCerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioSesion.aspx");
        }

        protected void ButtonPdf_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 20, XFontStyle.Bold);

            // Draw the text
            gfx.DrawString("Hello, World!", font, XBrushes.Black,
              new XRect(0, 0, page.Width, page.Height),
              XStringFormats.Center);

            // Save the document...
            string filename = (string)Session["path_pdf"] + "HelloWorld.pdf";
            document.Save(filename);
            Process.Start(filename);
        }
    }
}