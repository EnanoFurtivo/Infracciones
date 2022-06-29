﻿using System;
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
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Duenio usr = (Duenio)Session["usuario"];
                //refrescarLista(usr.GetAllInfracciones(), ListBoxInfracciones);
                //this.LabelBienvenida.Text = "Bienvenido/a de nuevo " + usr.Nombre;
            }
        }
        public void refrescarLista(List<Infraccion> infracciones, ListBox listBox)
        {
            listBox.Items.Clear();
            for(int i=0;i<infracciones.Count; i++)
                listBox.Items.Add(infracciones[i].ToString());
        }

        protected void ButtonGenerarPdf_Click(object sender, EventArgs e)
        {
            
        }

        protected void ButtonCerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioSesion.aspx");
        }

    }
}