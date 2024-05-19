<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="course and its prerequisites.aspx.cs" Inherits="WebApplication1.course_and_its_prerequisites" %>

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
            <asp:TextBox ID="id2" runat="server"></asp:TextBox>
            <br />
        <asp:Button ID="Button1" runat="server" Text="Done" OnClick="Button1_Click" />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
