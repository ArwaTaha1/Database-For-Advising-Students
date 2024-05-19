<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Advising_Team_7.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Please login</p>
        <p>
            Username</p>
        <asp:TextBox ID="Username" runat="server"></asp:TextBox>
        <br />
        <br />
        Password<br />
        <p>
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="signin" runat="server" Text="login" OnClick ="page1" /> 
    </form>
</body>
</html>
