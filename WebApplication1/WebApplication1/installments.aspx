<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="installments.aspx.cs" Inherits="project.installments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          Payment ID:  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="numberofinstallments" Text="Issue Installments" />
        </p>
    </form>
</body>
</html>
