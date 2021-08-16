<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroGrupoCuatrimestre.aspx.cs" Inherits="WebPresentacion.RegistroGrupoCuatrimestre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Grupo Cuatrimestre</title>

     <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.bundle.min.js"></script>

      <link href="css/sweetalert2.min.css" rel="stylesheet" />
    <script src="js/sweetalert2.all.min.js"></script>
    <script src="js/JavaScript.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>

         <div style="background-color:mediumseagreen">
         <nav class="navbar navbar-light bg-light">
         <div class="container-fluid" >
         <img src="IMG/UtpFondo.png"/>
         </nav>
         </div>


        <asp:Button ID="btnCargar" runat="server" class="btn btn-primary" Text="Cragar Datos." OnClick="btnCargar_Click"/>

        <br />
        <br />
         <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
         Registrar Grupo Cuatrimestre</button>
         <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
         <div class="modal-dialog">
         <div class="modal-content">
         <div class="modal-header">
         <h5 class="modal-title" id="exampleModalLabel">Bitacora | Grupo Cuatrimestre </h5>
         <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
         </div>
         <div class="modal-body">
         <div class="mb-3">
         <asp:Label ID="Label1" runat="server"  class="form-label" Text="Programa Educativo:"></asp:Label>
          <br />
         <asp:DropDownList ID="dropProgramaEd" runat="server"></asp:DropDownList>
          <br />
         <asp:Label ID="Label2" runat="server"  class="form-label" Text="Grupo:"></asp:Label>
          <br />
         <asp:DropDownList ID="dropGrupo" runat="server"></asp:DropDownList>
          <br />
         <asp:Label ID="Label5" runat="server"  class="form-label" Text="Cuatrimestre:"></asp:Label>
         <br />
         <asp:DropDownList ID="dropCuatri" runat="server"></asp:DropDownList>
          <br />
         <asp:Label ID="Label3" runat="server"  class="form-label" Text="Turno:"></asp:Label>
         <asp:TextBox ID="txtTurno" runat="server" class="form-control"></asp:TextBox>
         <asp:Label ID="Label4" runat="server"  class="form-label" Text="Modalidad:"></asp:Label>
         <asp:TextBox ID="txtModalidad" runat="server" class="form-control"></asp:TextBox>
         <asp:Label ID="Label6" runat="server"  class="form-label" Text="Extra:"></asp:Label>
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
            <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Bodoni MT Condensed" Font-Size="Large" Text="Grupo Cuatrimestre Seleccionada: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbMateria" runat="server" Text="________________"></asp:Label>
&nbsp;&nbsp;&nbsp;
         <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal1">
          Actualizar Grupo Cuatrimestre</button>
         <div class="modal fade" id="exampleModal1" tabindex="-1" aria-labelledby="exampleModalLabel1" aria-hidden="true">
         <div class="modal-dialog">
         <div class="modal-content">
         <div class="modal-header">
         <h5 class="modal-title" id="exampleModalLabe1l">Bitacora | Grupo Cuatrimestre </h5>
         <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
         </div>
         <div class="modal-body">
         <div class="mb-3">
         <asp:Label ID="Label8" runat="server"  class="form-label" Text="Programa Educativo:"></asp:Label>
          <br />
         <asp:DropDownList ID="dropProgramaEDA" runat="server"></asp:DropDownList>
          <br />
         <asp:Label ID="Label9" runat="server"  class="form-label" Text="Grupo:"></asp:Label>
          <br />
         <asp:DropDownList ID="dropGrupoA" runat="server"></asp:DropDownList>
          <br />
         <asp:Label ID="Label10" runat="server"  class="form-label" Text="Cuatrimestre:"></asp:Label>
         <br />
         <asp:DropDownList ID="dropCuatriA" runat="server"></asp:DropDownList>
          <br />
         <asp:Label ID="Label11" runat="server"  class="form-label" Text="Turno:"></asp:Label>
         <asp:TextBox ID="txtTurnoA" runat="server" class="form-control"></asp:TextBox>
         <asp:Label ID="Label12" runat="server"  class="form-label" Text="Modalidad:"></asp:Label>
         <asp:TextBox ID="txtModalidadA" runat="server" class="form-control"></asp:TextBox>
         <asp:Label ID="Label13" runat="server"  class="form-label" Text="Extra:"></asp:Label>
         <asp:TextBox ID="txtExtraA" runat="server" class="form-control"></asp:TextBox>
         </div>
         </div>
         <div class="modal-footer">
         <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
          <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="Actualizar" OnClick="Button2_Click1"  />
         </div>
         </div>
         </div>
         </div>
         <asp:Button ID="Button3" runat="server" class="btn btn-primary" Text="Eliminar" OnClick="Button3_Click" />
        </center>

         <div style="float:right">
        <asp:Button ID="Button4" runat="server" class="btn btn-primary" Text="Siguiente" OnClick="Button4_Click" />
       </div>   

    </form>
</body>
</html>
