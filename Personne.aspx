<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Personne.aspx.cs" Inherits="Personne" %>

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
        <h1>Register person<span>formrmulaire de tous les personnes</span></h1>
    <div>

        <div class="inner-wrap">
        <asp:Label ID="Label10" runat="server" Text="Label">Nom :</asp:Label>
        <asp:TextBox ID="nom" runat="server"></asp:TextBox>
       <asp:Label ID="Label1" runat="server" Text="Label">Prenom :</asp:Label>
        <asp:TextBox ID="prenom" runat="server"></asp:TextBox>
        <asp:Label ID="L" runat="server" Text="Genre :"></asp:Label>
        <asp:DropDownList ID="Dropgenre" runat="server">
            <asp:ListItem>select genre</asp:ListItem>
            <asp:ListItem>Femmin</asp:ListItem>
            <asp:ListItem>Masculin</asp:ListItem>
        </asp:DropDownList>
 
        <asp:Label ID="Lstat" runat="server" Text="Statut"></asp:Label>
        <asp:DropDownList ID="Dropstat" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem>select statut</asp:ListItem>
        </asp:DropDownList>
       
        <asp:Label ID="Lspecia" runat="server" Text="Specialite :"></asp:Label>
        <asp:TextBox ID="special" runat="server"></asp:TextBox>
        <asp:Label ID="Ltype" runat="server" Text="Type :"></asp:Label>
        <asp:DropDownList ID="Droptype" runat="server">
            <asp:ListItem>select type</asp:ListItem>
            <asp:ListItem>Labolatin</asp:ListItem>
            <asp:ListItem>Radiologue</asp:ListItem>
        </asp:DropDownList><br/>
        <asp:Label ID="Lage" runat="server" Text="Age :"></asp:Label>
        <asp:TextBox ID="age" runat="server"></asp:TextBox>
        <asp:Label ID="Lpoid" runat="server" Text="Poids"></asp:Label>
        <asp:TextBox ID="poid" runat="server" ></asp:TextBox>
        <asp:Label ID="Ltempe" runat="server" Text="Temperature :"></asp:Label>
        <asp:TextBox ID="tempe" runat="server"></asp:TextBox>
        <asp:Label ID="Lprofi" runat="server" Text="Profile :"></asp:Label>
        <asp:DropDownList ID="Dropprof" runat="server" OnSelectedIndexChanged="Dropprof_SelectedIndexChanged">
            <asp:ListItem>select type</asp:ListItem>
            <asp:ListItem>Admin</asp:ListItem>
            <asp:ListItem>simple User</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Lpwd" runat="server" Text="Password :"></asp:Label>
        <asp:TextBox ID="pwd" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ajouter" />
        
        
       
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
