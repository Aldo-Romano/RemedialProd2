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
        <br />

                

        <br />
        <center>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Bodoni MT Condensed" Font-Size="Large" Text="Carrera Seleccionada: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbCarrera" runat="server" Text="________________"></asp:Label>
&nbsp;&nbsp;&nbsp;

        <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal1">
        Actualizar Carrera</button>
         <div class="modal fade" id="exampleModal1" tabindex="-1" aria-labelledby="exampleModalLabel1" aria-hidden="true">
         <div class="modal-dialog">
         <div class="modal-content">
         <div class="modal-header">
         <h5 class="modal-title" id="exampleModalLabel1">Bitacora | Actualización Carrera </h5>
         <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
         </div>
         <div class="modal-body">
         <div class="mb-3">
         <asp:Label ID="Label3" runat="server"  class="form-label" Text="Nombre de la Carrera:"></asp:Label>
             <asp:DropDownList ID="dlCarrera1" runat="server">
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
        <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="Actualizar" OnClick="Button2_Click1" />
         </div>
         </div>
         </div>
         </div>          

        </div>&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" class="btn btn-primary" Text="Eliminar" OnClick="Button3_Click" />
            </center>


                         

    </form>
</body>
</html>
