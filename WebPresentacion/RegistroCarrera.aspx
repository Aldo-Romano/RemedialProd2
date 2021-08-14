<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroCarrera.aspx.cs" Inherits="WebPresentacion.RegistroCarrera" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro Carrera</title>

      <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.bundle.min.js"></script>

</head>
<body style="background-image:url(IMG/FondoW.jpg)">

    <form id="form1" runat="server">
        <div>

        <div style="background-color:mediumseagreen">
         <nav class="navbar navbar-light bg-light">
         <div class="container-fluid">
         <img src="IMG/UtpFondo.png"/>
         <ul class="navbar-nav me-auto mb-2 mb-lg-0">
         <li class="nav-item">
         <a class="navbar-brand" href="Inicio.aspx">Inicio</a>
         </li>
         </ul>
         <ul class="navbar-nav me-auto mb-2 mb-lg-0">
          <li class="nav-item">
          <a class="navbar-brand" href="RegistroCarrera.aspx">Registro Carrera</a>
          </li>
          </ul>
         </div>
         </nav>
         </div>
            
          <br />

       <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
        Registrar Carrera</button>
         <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
         <div class="modal-dialog">
         <div class="modal-content">
         <div class="modal-header">
         <h5 class="modal-title" id="exampleModalLabel">Bitacora | Registro Carrera </h5>
         <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
         </div>
         <div class="modal-body">
         <div class="mb-3">
         <asp:Label ID="Label1" runat="server"  class="form-label" Text="Nombre de la Carrera:"></asp:Label>
             <asp:DropDownList ID="dlCarrera" runat="server">
                          <asp:ListItem></asp:ListItem>
                          <asp:ListItem>Ambiental</asp:ListItem>
                          <asp:ListItem>Automotriz</asp:ListItem>
                          <asp:ListItem>Energías Renovables</asp:ListItem>
                          <asp:ListItem>Gastronomía</asp:ListItem>
                          <asp:ListItem>Ing Industrial</asp:ListItem>
                          <asp:ListItem>Mantenimineto</asp:ListItem>
                          <asp:ListItem>Mecatrónica</asp:ListItem>
                          <asp:ListItem>Negocios</asp:ListItem>
                          <asp:ListItem>Tecnologías de la Información</asp:ListItem>
            </asp:DropDownList>
         </div>
         </div>
         <div class="modal-footer">
         <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
         <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Registrar" OnClick="Button1_Click" />         </div>
         </div>
         </div>
         </div>

                      

        </div>
    </form>
</body>
</html>
