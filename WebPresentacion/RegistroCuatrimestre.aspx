<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroCuatrimestre.aspx.cs" Inherits="WebPresentacion.RegistroCuatrimestre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro Cuatrimestre</title>

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

        <br />
         <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
         Registrar Cuatrimestre</button>
         <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
         <div class="modal-dialog">
         <div class="modal-content">
         <div class="modal-header">
         <h5 class="modal-title" id="exampleModalLabel">Bitacora | Cuatrimestre </h5>
         <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
         </div>
         <div class="modal-body">
         <div class="mb-3">
         <asp:Label ID="Label1" runat="server"  class="form-label" Text="Periodo:"></asp:Label>
         <asp:TextBox ID="txtPeriodo" runat="server" class="form-control"></asp:TextBox>
         <asp:Label ID="Label2" runat="server"  class="form-label" Text="Año:"></asp:Label>
         <asp:TextBox ID="txtAnio" runat="server" class="form-control"></asp:TextBox>
         <asp:Label ID="Label3" runat="server"  class="form-label" Text="Inicio:"></asp:Label>
         <br />
          <asp:Calendar ID="CLInicio" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
              <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
              <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
              <OtherMonthDayStyle ForeColor="#999999" />
              <SelectedDayStyle BackColor="#333399" ForeColor="White" />
              <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
              <TodayDayStyle BackColor="#CCCCCC" />
             </asp:Calendar>
         <asp:Label ID="Label4" runat="server"  class="form-label" Text="Fin:"></asp:Label>
         <br />
         <asp:Calendar ID="CLFin" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
             <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
             <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
             <OtherMonthDayStyle ForeColor="#999999" />
             <SelectedDayStyle BackColor="#333399" ForeColor="White" />
             <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
             <TodayDayStyle BackColor="#CCCCCC" />
             </asp:Calendar>
         <asp:Label ID="Label5" runat="server"  class="form-label" Text="Extra:"></asp:Label>
         <asp:TextBox ID="txtExtra" runat="server" class="form-control"></asp:TextBox>
         </div>
         </div>
         <div class="modal-footer">
         <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
         <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="Registrar" OnClick="Button2_Click"/>
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
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Bodoni MT Condensed" Font-Size="Large" Text="Cuatrimestre Seleccionada: "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbCuatri" runat="server" Text="________________"></asp:Label>
&nbsp;&nbsp;&nbsp;
         <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal1">
          Actualizar Cuatrimestre</button>
         <div class="modal fade" id="exampleModal1" tabindex="-1" aria-labelledby="exampleModalLabel1" aria-hidden="true">
         <div class="modal-dialog">
         <div class="modal-content">
         <div class="modal-header">
         <h5 class="modal-title" id="exampleModalLabe1l">Bitacora | Cuatrimestre </h5>
         <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
              </div>
         <div class="modal-body">
         <div class="mb-3">
         <asp:Label ID="Label7" runat="server"  class="form-label" Text="Periodo:"></asp:Label>
         <asp:TextBox ID="txtPeriodoA" runat="server" class="form-control"></asp:TextBox>
         <asp:Label ID="Label8" runat="server"  class="form-label" Text="Año:"></asp:Label>
         <asp:TextBox ID="txtAñoA" runat="server" class="form-control"></asp:TextBox>
         <asp:Label ID="Label9" runat="server"  class="form-label" Text="Inicio:"></asp:Label>
         <br />
          <asp:Calendar ID="CLInicioA" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
              <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
              <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
              <OtherMonthDayStyle ForeColor="#999999" />
              <SelectedDayStyle BackColor="#333399" ForeColor="White" />
              <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
              <TodayDayStyle BackColor="#CCCCCC" />
             </asp:Calendar>
         <asp:Label ID="Label10" runat="server"  class="form-label" Text="Fin:"></asp:Label>
         <br />
         <asp:Calendar ID="CLFinA" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
             <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
             <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
             <OtherMonthDayStyle ForeColor="#999999" />
             <SelectedDayStyle BackColor="#333399" ForeColor="White" />
             <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
             <TodayDayStyle BackColor="#CCCCCC" />
             </asp:Calendar>
         <asp:Label ID="Label11" runat="server"  class="form-label" Text="Extra:"></asp:Label>
         <asp:TextBox ID="txtExtraA" runat="server" class="form-control"></asp:TextBox>
         </div>
         </div>
         <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
         <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Actualizar"  OnClick="Button1_Click" />
         </div>
         </div>
         </div>
         </div>    
                      

        <asp:Button ID="Button3" runat="server" class="btn btn-primary" Text="Eliminar" OnClick="Button3_Click" />
        </center>

        <div style="float:right">
            <asp:Button ID="Button4" runat="server" class="btn btn-primary" Text="Siguiente" OnClick="Button4_Click"  />
            </div>  

    </form>
</body>
</html>
