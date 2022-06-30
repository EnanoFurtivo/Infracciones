<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs"
Inherits="UIWeb.InicioSesion" %>

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
          <asp:Label
            ID="LabelInicioSesion"
            Font-Size="XX-Large"
            Font-Bold="True"
            Font-Italic="False"
            runat="server"
            Text="INICIO SESIÓN"
          ></asp:Label>


          <asp:TextBox
            ID="TxtBoxDni"
            class="form-control mb-3 mt-3"
            type="text"
            runat="server"
          ></asp:TextBox>

          <asp:TextBox
            ID="TxtBoxClave"
            class="form-control mb-3"
            type="password"
            runat="server"
            TextMode="Password"
          ></asp:TextBox>

          <asp:Button
            ID="ButIngresar"
            class="btn btn-success mb-3"
            runat="server"
            Text="Ingresar"
            OnClick="ButtonIngresar_Click"
          />

          <asp:Label ID="LabelDeError" class="text-red" runat="server"></asp:Label>
        </div>
      </form>
    </div>
  </body>
</html>
