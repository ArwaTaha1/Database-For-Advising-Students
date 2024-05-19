<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Graduation plan.aspx.cs" Inherits="WebApplication1.Graduation_plan" %>

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
            <asp:TextBox ID="gradp" runat="server" style="height: 25px"></asp:TextBox>
             <br />
            <br />
        <asp:Button ID="Button1" runat="server" Text="Done" OnClick="Button1_Click" />
             <br />
             <br />
             <asp:GridView ID="GridView1" runat="server">

             </asp:GridView>
        </div>
    </form>
</body>
</html>
