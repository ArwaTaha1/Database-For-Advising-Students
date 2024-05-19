<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Optional.aspx.cs" Inherits="arwa.Optional" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        Student ID
        <br />
        <asp:TextBox ID="ID" runat="server"></asp:TextBox>
        <br />
        <br />
        Current Semester Code<br />
        <asp:TextBox ID="semester" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick ="view" Text="View Optional Courses" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
    </form>
</body>
</html>
