<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="unpaid installment.aspx.cs" Inherits="WebApplication1.unpaid_installment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <body>
<form id="form1" runat="server">
        <div>
             <asp:Label ID="Label11" runat="server" Text="Student ID:"></asp:Label>
             <br />
            <br />
            <asp:TextBox ID="sID" runat="server"></asp:TextBox>
             <br />
            <br />
        <asp:Button ID="Button1" runat="server" Text="Done" OnClick="Button1_Click" />
             <br />
             <br />
        </div>
    </form>
</body>
</html>
