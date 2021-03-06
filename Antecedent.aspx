<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Antecedent.aspx.cs" Inherits="Antecedent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="style/personne.css" />
    <link href="style/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="style/materialdesignicons.min.css"/>
    <link href="style/menustyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="d-flex" id="wrapper">
<div class="bg-light border-light" id ="sidebar-wrapper">
<div class="sidebar-heading">Hopital Home</div>
<div class="list-group list-group-flush">
<a href="Menu.aspx" class="list-group-item list-group-item-action bg-light">Dashboard</a>
<a href="Personne.aspx" class="list-group-item list-group-item-action bg-light">personne</a>
<a href="Consultation.aspx" class="list-group-item list-group-item-action bg-light">Consultation</a>
<a href="Hospitalisation.aspx" class="list-group-item list-group-item-action bg-light">Hospitalisation</a>
<a href="Examen.aspx" class="list-group-item list-group-item-action bg-light">Examen</a>
<a href="PatientAnte.aspx" class="list-group-item list-group-item-action bg-light">Patient Antecedent</a>
<a href="Services.aspx" class="list-group-item list-group-item-action bg-light">Services</a>
<a href="Chambre.aspx" class="list-group-item list-group-item-action bg-light">Chambre</a>
<a href="Antecedent.aspx" class="list-group-item list-group-item-action bg-light">Antecedent</a>
<a href="Documents.aspx" class="list-group-item list-group-item-action bg-light">Document</a>
<a href="Morgue.aspx" class="list-group-item list-group-item-action bg-light">Morgue</a>


</div>

</div>

<div id="page-content-wrapper">
<nav class="navbar navbar-expand-lg navbar-light bg-light border-bottom">
<button type="button" id="menu-toggle" class="btn btn-primary">
<i class="mdi mdi-format-list-bulleted"></i>
<span class="sr-only">Toggle Menu</span>
</button>
</nav>

<div class="container-fluid">
    <div class="form-style-10">
        <h1>Register Antecedent<span>formulaire d'ajout d'un nouveau Antecedent</span></h1>

        <div>

        <div class="inner-wrap">
        <asp:Label ID="Label1" runat="server" Text="Label">Nom </asp:Label><br/>
        <asp:TextBox ID="ante" runat="server" Height="16px"></asp:TextBox><br/>
        <br/>
        <asp:Button class="btn" ID="add" runat="server" Text="Ajouter" OnClick="add_Click" />
        <asp:Button class="btn" ID="mod" runat="server" Text="Modifier" />
        <asp:Button class="btn" ID="rech" runat="server" Text="Rechercher" />
        <br />
        <br />
                    </div>
            </div>
</div>
    </div>
    </div>
    </div>
        <script src="style/js/bootstrap.min.js"></script>
<script src="style/js/jquery.min.js"></script>

<script>
    $("#menu-toggle").click(function (e) {
        e.preventDefault();
        $("#wrapper").toggleClass("toggled");

    });
</script>

<div class="container body-content">

<hr />
<footer>
<p>&copy; RashiCode.com <%: DateTime.Now.Year %> - My ASP.NET Application Simple Sidebar</p>
</footer>
</div>
    </form>
</body>
</html>
