<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advisor_Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PLEASE LOG IN
          </div>
        <div>&nbsp;ID</div>
        <div>
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            &nbsp;</div>
        <div>&nbsp;Password</div>
        <div>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>&nbsp;</div>
        <div>
            <asp:Button ID="log" runat="server" OnClick="login" Text="Log in"></asp:Button>&nbsp;</div>
        
    </form>
</body>
</html>
