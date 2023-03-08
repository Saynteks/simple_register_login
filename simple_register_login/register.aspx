<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="simple_register_login.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Kayıt Sayfası</title>
     <link rel="stylesheet" href="style.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="register-form">
            <h1 class="header">KAYIT OL</h1>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="input" placeholder="Username"></asp:TextBox><br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="input" placeholder="Password"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Kayıt Ol" CssClass="button" OnClick="Button1_Click" />
            <p class="check">Zaten hesabın var mı?
                <a href="/login.aspx" class="sign-in-link">Oturum aç</a>
            </p>
        </div>
    </form>
</body>
</html>
