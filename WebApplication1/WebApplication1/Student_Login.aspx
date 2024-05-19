<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_Login.aspx.cs" Inherits="arwa.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Login
        </p>
        <p>
            User_ID
        </p>
        <p>
            <asp:TextBox ID="ID" runat="server"></asp:TextBox>
        </p>
        <p>
            Password
        </p>
        <p>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick ="ToHomePage" />
        </p>
    </form>
</body>
</html>
