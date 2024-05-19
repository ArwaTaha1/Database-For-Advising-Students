<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="required.aspx.cs" Inherits="arwa.required" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student ID
            <br />
            <asp:TextBox ID="ID" runat="server"></asp:TextBox>
            <br />
            <br />
            Current Semester Code<br />
            <asp:TextBox ID="semester" runat="server"></asp:TextBox>
            <br />
&nbsp;</div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick ="view" Text="View Required Courses" />
        </p>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
