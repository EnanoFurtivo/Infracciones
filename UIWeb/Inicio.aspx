<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs"
Inherits="UIWeb.Inicio" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Infracciones</title>

    <!-- Bootstrap -->
    <script src="bootstrap/js/bootstrap.js"></script>
    <link rel="stylesheet" href="bootstrap/css/bootstrap.css" />
    <link rel="stylesheet" href="bootstrap/css/bootstrap-utilities.css" />
    <link rel="stylesheet" href="bootstrap/icons/bootstrap-icons.css" />

    <style>
      body {
        background-color: rgb(25, 60, 85);
      }
      .div-flex {
        display: flex;
      }
      .div-centered {
        justify-content: center;
      }
    </style>
  </head>

  <body class="vh-100 vw-100">
    <div class="div-flex div-centered text-white">
      <form id="form1" runat="server">
        <div
          class="vh-100 d-flex flex-column overflow-hidden div-flex div-centered"
        >
          <asp:Image ID="Image1" runat="server" />
          <asp:Label
            class="mb-1"
            ID="LabelBienvenida"
            runat="server"
            Text="Label"
            Font-Size="XX-Large"
            Font-Bold="True"
            Font-Italic="False"
          ></asp:Label>
         
         <div class="div-flex flex-row">
          <asp:Label
            ID="LabelLista"
            runat="server"
            Text="Sus infracciones Pagas:"
            style="margin-right:355px;"
          ></asp:Label>

          <asp:Label
            ID="Label2"
            runat="server"
            Text="Sus infracciones Pendientes:"
          ></asp:Label>
          </div>

          <div class="div-flex flex-row div-centered">
            <asp:ListBox
              class="form-select"
              ID="ListBoxInfraccionesPagas"
              runat="server"
              Height="250px"
              style="overflow-x: auto"
            ></asp:ListBox>

            <asp:ListBox
              class="form-select ms-3"
              ID="ListBoxInfracciones"
              runat="server"
              Height="250px"
              style="overflow-x: auto"
            ></asp:ListBox>

            <div class="div-flex flex-column">
              <asp:Button
                class="btn btn-success mb-3 ms-3"
                ID="ButtonPdf"
                runat="server"
                Text="Generar orden de pago"
                OnClick="ButtonPdf_Click"
              />

              <asp:Button
                class="btn btn-danger ms-3"
                ID="ButtonCerrarSesion"
                runat="server"
                OnClick="ButtonCerrarSesion_Click"
                Text="Cerrar Sesión"
              />
            </div>
          </div>
        </div>
      </form>
    </div>
  </body>
</html>
