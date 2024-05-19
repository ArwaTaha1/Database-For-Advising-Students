<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="active.aspx.cs" Inherits="project.active" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="ActiveStudents" Text="Fetch Details of Active Students" />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
