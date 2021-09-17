<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Authentification.aspx.cs" Inherits="Authentification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="style/author.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="wrap">
            <h2>Authentification</h2>
            <div class="form">
                <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="ID User"></asp:Label>
                <asp:TextBox ID="id" runat="server" TextMode="Number"></asp:TextBox>
                </div>
                <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Mot de passe"></asp:Label>
                <asp:TextBox ID="pwd" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
