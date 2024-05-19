<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="WebApplication1.Start1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Button ID="Button1" runat="server" OnClick="Admin" Text="Admin" /><div>&nbsp;</div>
             <asp:Button ID="Button2" runat="server" OnClick="Advisor" Text="Advisor" /><div>&nbsp;</div>
             <asp:Button ID="Button3" runat="server" OnClick="Student" Text="Student" />

        </div>
    </form>
</body>
</html>
