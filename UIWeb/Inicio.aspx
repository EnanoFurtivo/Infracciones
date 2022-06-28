<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="UIWeb.Inicio" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">

        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Infracciones</title>

        <!-- Bootstrap -->
        <script src="bootstrap/js/bootstrap.js"></script>
        <link rel="stylesheet" href="bootstrap/css/bootstrap.css"/>
        <link rel="stylesheet" href="bootstrap/css/bootstrap-utilities.css"/>
        <link rel="stylesheet" href="bootstrap/icons/bootstrap-icons.css"/>

    </head>

    <body class="vh-100 vw-100">
            <form class="flex flex-column text-center align-middle" id="form1" runat="server">

                <asp:Label ID="LabelBienvenida" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>
                <asp:Label ID="LabelLista" runat="server" Text="Sus infracciones"></asp:Label>
                <asp:ListBox class="form-select" ID="ListBoxInfracciones" runat="server" Height="249px" Width="195px" style="overflow-x:auto;"></asp:ListBox>
                <asp:Button class="btn btn-success" ID="ButtonPdf" runat="server" Text="Generar orden de pago" OnClick="ButtonInscribirse_Click" />
                <asp:Button class="btn btn-danger" ID="ButtonCerrarSesion" runat="server" OnClick="ButCerrarSesion_Click" Text="Cerrar Sesión" />

            </form>
        
    </body>

</html>
