<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroMateria.aspx.cs" Inherits="WebPresentacion.RegistroMateria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro Materia</title>

    
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.bundle.min.js"></script>

      <link href="css/sweetalert2.min.css" rel="stylesheet" />
    <script src="js/sweetalert2.all.min.js"></script>
    <script src="js/JavaScript.js"></script>


</head>
<body style="background-image:url(IMG/FondoW.jpg)">
    <form id="form1" runat="server">
        <div>

           <div style="background-color:mediumseagreen">
         <nav class="navbar navbar-light bg-light">
         <div class="container-fluid" >
         <img src="IMG/UtpFondo.png"/>
         </nav>
         </div>

        <br />
         <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
         Registrar Materia</button>
         <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
         <div class="modal-dialog">
         <div class="modal-content">
         <div class="modal-header">
         <h5 class="modal-title" id="exampleModalLabel">Bitacora | Materia </h5>
         <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
         </div>
         <div class="modal-body">
         <div class="mb-3">
         <asp:Label ID="Label1" runat="server"  class="form-label" Text="Materia:"></asp:Label>
         <asp:TextBox ID="txtMateria" runat="server" class="form-control"></asp:TextBox>
         <asp:Label ID="Label2" runat="server"  class="form-label" Text="Horas a la Semana:"></asp:Label>
         <asp:TextBox ID="txtHora" runat="server" class="form-control"></asp:TextBox>
         <asp:Label ID="Label5" runat="server"  class="form-label" Text="Extra:"></asp:Label>
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
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Bodoni MT Condensed" Font-Size="Large" Text="Materia Seleccionada: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbMateria" runat="server" Text="________________"></asp:Label>
&nbsp;&nbsp;&nbsp;
         <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal1">
          Actualizar Materia</button>
         <div class="modal fade" id="exampleModal1" tabindex="-1" aria-labelledby="exampleModalLabel1" aria-hidden="true">
         <div class="modal-dialog">
         <div class="modal-content">
         <div class="modal-header">
         <h5 class="modal-title" id="exampleModalLabe1l">Bitacora | Materia </h5>
         <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
         </div>
         <div class="modal-body">
         <div class="mb-3">
         <asp:Label ID="Label3" runat="server"  class="form-label" Text="Materia:"></asp:Label>
         <asp:TextBox ID="txtMateriaA" runat="server" class="form-control"></asp:TextBox>
         <asp:Label ID="Label4" runat="server"  class="form-label" Text="Horas a la Semana:"></asp:Label>
         <asp:TextBox ID="txtHorasA" runat="server" class="form-control"></asp:TextBox>
         <asp:Label ID="Label7" runat="server"  class="form-label" Text="Extra:"></asp:Label>
         <asp:TextBox ID="txtExtraA" runat="server" class="form-control"></asp:TextBox>
         </div>
         </div>
         <div class="modal-footer">
         <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
         <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="Actualizar" OnClick="Button2_Click"  />
         </div>
         </div>
         </div>
         </div>
         <asp:Button ID="Button3" runat="server" class="btn btn-primary" Text="Eliminar" OnClick="Button3_Click" />
        </center>

    </form>
</body>
</html>
