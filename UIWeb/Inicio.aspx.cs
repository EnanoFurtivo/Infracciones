using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using QRCoder;

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
            if (ListBoxInfracciones.SelectedIndex != -1)
            {
                Infraccion infraccion = Infracciones[ListBoxInfracciones.SelectedIndex];

                string datosQrStr = "ORDEN DE PAGO\n" +
                    "Dominio del vehiculo: " + infraccion.Vehiculo.Dominio + "\n" +
                    "Numero de infraccion: #" + infraccion.NumeroInfraccion + "\n" +
                    "Fecha de infraccion: " + infraccion.FechaInfraccion.ToString("dd/MM/yyyy") + "\n" +
                    "Fecha de vencimiento de infraccion: " + infraccion.FechaVencimiento.ToString("dd/MM/yyyy") + "\n" +
                    "Importe base: $" + infraccion.ImporteBase + "\n" +
                    "Descuento: $" + infraccion.GetDescuentoActual() + "\n" +
                    "Importe a pagar: $" + infraccion.MontoInfraccion + "\n" +
                    "Fecha de vencimiento orden de pago: " + DateTime.Now.ToString("dd/MM/yyyy");
                
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(datosQrStr, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(qrCodeData);
                
                Bitmap qrbmp = code.GetGraphic(100);
                Stream stream = new MemoryStream();
                qrbmp.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                XImage qr = XImage.FromStream(stream);

                PdfDocument document = new PdfDocument();
                document.Info.Title = "Orden Pago Infraccion";
                document.Info.Author = "Sistema de Infracciones";

                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Arial", 15);
                XFont fontTitle = new XFont("Arial", 40, XFontStyle.Bold|XFontStyle.Underline);
                XFont fontBold = new XFont("Arial", 15, XFontStyle.Bold);
                XImage image = XImage.FromFile((string)Session["path_logo"]);

                // Dibujar el texto
                int interlineado = 30;
                int margenInicioX = 40;
                int margenInicioY = 40;
                double margenFinX = page.Width - (margenInicioX * 2);
                double margenFinY = page.Height - (margenInicioY * 2);

                XBrush brush = XBrushes.Black;
                gfx.DrawRectangle(brush, new XRect(10, 10, page.Width -20, page.Height -20));
                gfx.DrawRectangle(XBrushes.White, new XRect(15, 15, page.Width - 30, page.Height - 30));

                gfx.DrawImage(image, margenInicioX -20, margenInicioY -20, 100, 100);
                gfx.DrawImage(image, margenFinX -40, margenInicioY - 20, 100, 100);

                gfx.DrawString("ORDEN DE PAGO", fontTitle, XBrushes.Black,
                  new XRect(margenInicioX, margenInicioY, margenFinX, margenFinY),
                  XStringFormats.TopCenter);
                margenInicioY += 100;

                gfx.DrawString("Dominio del vehiculo: " + infraccion.Vehiculo.Dominio, font, XBrushes.Black,
                  new XRect(margenInicioX, margenInicioY, margenFinX, margenFinY),
                  XStringFormats.TopLeft);
                margenInicioY += interlineado;

                gfx.DrawString("Numero de infraccion: #" + infraccion.NumeroInfraccion, font, XBrushes.Black,
                  new XRect(margenInicioX, margenInicioY, margenFinX, margenFinY),
                  XStringFormats.TopLeft);
                margenInicioY += interlineado;

                gfx.DrawString("Descripcion: " + infraccion.TipoInfraccion.Descripcion, font, XBrushes.Black,
                  new XRect(margenInicioX, margenInicioY, margenFinX, margenFinY),
                  XStringFormats.TopLeft);
                margenInicioY += interlineado;

                gfx.DrawString("Fecha de infraccion: " + infraccion.FechaInfraccion.ToString("dd/MM/yyyy"), font, XBrushes.Black,
                  new XRect(margenInicioX, margenInicioY, margenFinX, margenFinY),
                  XStringFormats.TopLeft);
                margenInicioY += interlineado;

                gfx.DrawString("Fecha de vencimiento de infraccion: " + infraccion.FechaVencimiento.ToString("dd/MM/yyyy"), font, XBrushes.Black,
                  new XRect(margenInicioX, margenInicioY, margenFinX, margenFinY),
                  XStringFormats.TopLeft);
                margenInicioY += interlineado + 30;

                gfx.DrawString("Importe base: $" + infraccion.ImporteBase, font, XBrushes.Black,
                  new XRect(margenInicioX, margenInicioY, margenFinX, margenFinY),
                  XStringFormats.TopLeft);
                margenInicioY += interlineado;

                gfx.DrawString("Descuento: $" + infraccion.GetDescuentoActual(), font, XBrushes.Black,
                  new XRect(margenInicioX, margenInicioY, margenFinX, margenFinY),
                  XStringFormats.TopLeft);
                margenInicioY += interlineado;

                gfx.DrawString("Importe a pagar: $" + infraccion.MontoInfraccion, fontBold, XBrushes.Black,
                  new XRect(margenInicioX, margenInicioY, margenFinX, margenFinY),
                  XStringFormats.TopLeft);
                margenInicioY += interlineado + 30;

                gfx.DrawString("Fecha de vencimiento orden de pago: " + DateTime.Now.ToString("dd/MM/yyyy"), font, XBrushes.Black,
                  new XRect(margenInicioX, margenInicioY, margenFinX, margenFinY),
                  XStringFormats.TopLeft);
                margenInicioY += interlineado + 50;

                gfx.DrawImage(qr, margenInicioX, margenInicioY, 250, 250);

                // Save the document...
                string filename = (string)Session["path_pdf"] + "Infraccion_" + infraccion.NumeroInfraccion + "_" +infraccion.Vehiculo.Dominio + ".pdf";
                document.Save(filename);
                Process.Start(filename);
            }
        }
    }
}