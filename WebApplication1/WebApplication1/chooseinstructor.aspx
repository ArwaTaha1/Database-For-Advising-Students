<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chooseinstructor.aspx.cs" Inherits="WebApplication1.chooseinstructor" %>

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
            <asp:TextBox ID="id" runat="server"></asp:TextBox>
             <br />
             <asp:Label ID="Label12" runat="server" Text="Course ID:"></asp:Label>
            <br />
            <asp:TextBox ID="id0" runat="server"></asp:TextBox>
             <br />
             <asp:Label ID="Label13" runat="server" Text="Current Semester:"></asp:Label>
            <br />
            <asp:TextBox ID="id1" runat="server"></asp:TextBox>
             <br />
             <asp:Label ID="Label14" runat="server" Text="Instructor ID:"></asp:Label>
            <br />
            <asp:TextBox ID="id2" runat="server"></asp:TextBox>
            <br />
        <asp:Button ID="Button1" runat="server" Text="Done" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
