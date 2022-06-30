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
            runat="server"
            Text="INICIO SESIÓN"
          ></asp:Label>

          <asp:Button
            ID="ButIngresar"
            runat="server"
            Text="Ingresar"
            OnClick="ButtonIngresar_Click"
          />

          <asp:TextBox
            ID="TxtBoxDni"
            runat="server"
          ></asp:TextBox>

          <asp:TextBox
            ID="TxtBoxClave"
            runat="server"
            TextMode="Password"
          ></asp:TextBox>

          <asp:Label ID="LabelDeError" runat="server"></asp:Label>
        </div>
      </form>
    </div>
  </body>
</html>
