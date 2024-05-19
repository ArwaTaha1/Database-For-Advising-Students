<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="all.aspx.cs" Inherits="arwa.all" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Current Semester Code<br />
            <asp:TextBox ID="semester" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="view" Text="View All Courses in Current Semester" style="height: 26px" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" >
            </asp:GridView>
        </div>
    </form>
</body>
</html>
