<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="arwa.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
        </div>
        <asp:Button ID="register" runat="server" OnClick="toRegisterPage" Text="Register New Student" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="login" runat="server" OnClick="toLoginPage" Text="Login to your account" />
        </p>
    </form>
</body>
</html>
