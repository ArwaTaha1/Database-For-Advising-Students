<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advisor_Registration.aspx.cs" Inherits="WebApplication1.Advisor_Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Register As An Advisor
        <div>&nbsp;</div>
        Please Enter The Following Details: <div>&nbsp;</div>
        Name: <asp:TextBox ID="n" runat="server"></asp:TextBox>
      </div>
         <div>&nbsp;</div>
        Password: <asp:TextBox ID="p" runat="server"></asp:TextBox>
         <div>&nbsp;</div>
         Email: <asp:TextBox ID="em" runat="server"></asp:TextBox>
         <div>&nbsp;</div>
         Office: <asp:TextBox ID="o" runat="server"></asp:TextBox>
         <div>&nbsp;</div>
         <asp:Button ID="Button1" runat="server" OnClick="insert" Text="Register" />
         <div>&nbsp;</div>
         <asp:Button ID="Button2" runat="server" Text="Login" OnClick="Advisor_Page" Visible="false" />

    </form>
</body>
</html>
