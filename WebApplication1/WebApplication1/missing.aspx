<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="missing.aspx.cs" Inherits="arwa.missing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Student ID
            <br />
            <asp:TextBox ID="ID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="view" Text="View Missing Courses" />
            <br />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
    </body>
</html>
