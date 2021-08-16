<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProgramasEducativosenCarreras.aspx.cs" Inherits="WebPresentacion.ProgramasEducativosenCarreras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Programas Educativos en Carreras</title>

    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.bundle.min.js"></script>

      <link href="css/sweetalert2.min.css" rel="stylesheet" />
    <script src="js/sweetalert2.all.min.js"></script>
    <script src="js/JavaScript.js"></script>

</head>
<body style="background-image:url(IMG/FondoW.jpg)">
    <form id="form1" runat="server">
       

         <div style="background-color:mediumseagreen">
         <nav class="navbar navbar-light bg-light">
         <div class="container-fluid">
         <img src="IMG/UtpFondo.png"/>
         </nav>
         </div>

          <br />
        
        <div>
        <asp:Button ID="btnCargar" runat="server" class="btn btn-primary" Text="Cargar Datos." OnClick="btnCargar_Click"/>
        <br />
        <br />
        <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
         Mostrar Programas Educativos en Carreras</button>
         <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
         <div class="modal-dialog">
         <div class="modal-content">
         <div class="modal-header">
         <h5 class="modal-title" id="exampleModalLabel">Bitacora | Programa Educativo en Carreras </h5>
         <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
         </div>
         <div class="modal-body">
         <div class="mb-3">
         <asp:Label ID="Label1" runat="server"  class="form-label" Text="Nombre de la Carrera:"></asp:Label>
          <br />
         <asp:DropDownList ID="dropCarrera" runat="server"></asp:DropDownList>
         <div class="modal-footer">
         <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
          <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Mostrar" OnClick="Button2_Click"/>
         </div>
         </div>
         </div>
         </div>
        </div>
         </div>


            <center>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
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
           </center>

              <br />
             <br />
             <br />
                 
        <br />

         <div>
         <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal1">
         Mostrar Grupos Asociados a un Cuatrimestre</button>
         <div class="modal fade" id="exampleModal1" tabindex="-1" aria-labelledby="exampleModalLabel1" aria-hidden="true">
         <div class="modal-dialog">
         <div class="modal-content">
         <div class="modal-header">
         <h5 class="modal-title" id="exampleModalLabel1">Bitacora | Grupos Asociados en Carreras </h5>
         <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
         </div>
         <div class="modal-body">
         <div class="mb-3">
         <asp:Label ID="Label2" runat="server"  class="form-label" Text="Nombre de la Carrera:"></asp:Label>
          <br />
         <asp:DropDownList ID="dropCarrera1" runat="server"></asp:DropDownList>
             <br />
         <asp:Label ID="Label3" runat="server"  class="form-label" Text="Perido del Cuatrimestre:"></asp:Label>
          <br />
         <asp:DropDownList ID="dropPeriodoC" runat="server"></asp:DropDownList>
         <div class="modal-footer">
         <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
         <asp:Button ID="btnMostrarAc" class="btn btn-primary" runat="server" Text="Mostrar" OnClick="btnMostrarAc_Click" />
         </div>
         </div>
         </div>
         </div>
        </div>
         </div>

            <center>
            <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
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
           </center>



            
            <div style="float:right">
            <asp:Button ID="Button4" runat="server" class="btn btn-primary" Text="Finalizar" OnClick="Button4_Click" />
            </div>   
                             
 

    </form>
</body>
</html>
