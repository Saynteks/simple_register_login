<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="simple_register_login.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" href="style.css"/>
    <title>Giriş Sayfası</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="register-form">
            <h1 class="header">GİRİŞ YAP</h1>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="input" placeholder="Username"></asp:TextBox><br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="input" placeholder="Password"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Oturum Aç" CssClass="button" OnClick="Button1_Click" />
            <p class="check">Hesabın yok mu?
                <a href="/register.aspx" class="sign-up-link">Kayıt Ol</a>
            </p>
        </div>
    </form>
</body>
</html>
