<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebPresentacion.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>

    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.bundle.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">

      
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
          <a class="navbar-brand" href="RegistroCarrera.aspx">Empezar</a>
          </li>
          </ul>
         </div>
         </nav>
         </div>

          <br />

         <div id="carouselExampleSlidesOnly" class="carousel slide" data-bs-ride="carousel">
         <div class="carousel-inner">
         <div class="carousel-item active">
         <img src="IMG/IMG1.jpg" class="d-block w-100" style="height:500px; width:800px;"/>
         </div>
         <div class="carousel-item">
        <img src="IMG/IMG2.jpg" class="d-block w-100" style="height:500px; width:800px;"/>
        </div>
        <div class="carousel-item">
        <img src="IMG/IMG3.png" class="d-block w-100" style="height:500px; width:800px;"/>
        </div>
        </div>
       </div>

  
    </form>
</body>
</html>
