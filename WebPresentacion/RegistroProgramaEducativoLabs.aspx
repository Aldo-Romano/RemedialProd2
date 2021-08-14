<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroProgramaEducativoLabs.aspx.cs" Inherits="WebPresentacion.RegistroProgramaEducativoLabs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.bundle.min.js"></script>


</head>
<body>
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
         <h5 class="modal-title" id="exampleModalLabel">Bitacora | Programa Educativo </h5>
         <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
         </div>
         <div class="modal-body">
         <div class="mb-3">
         <asp:Label ID="Label1" runat="server"  class="form-label" Text="Programa Educativo:"></asp:Label>
         <asp:TextBox ID="txtProgramaEd" runat="server" class="form-control"></asp:TextBox>
         <asp:Label ID="Label2" runat="server"  class="form-label" Text="Carrera Seleccionada:"></asp:Label>
         <asp:DropDownList ID="dlCarrera" runat="server"></asp:DropDownList>
         <asp:Label ID="Label3" runat="server"  class="form-label" Text="Extra:"></asp:Label>
         <asp:TextBox ID="txtExtra" runat="server" class="form-control"></asp:TextBox>
         </div>
         </div>
         <div class="modal-footer">
         <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
         <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Registrar" OnClick="Button1_Click"/>
         </div>
         </div>
         </div>
         </div>
        </div>

          
    </form>
</body>
</html>
