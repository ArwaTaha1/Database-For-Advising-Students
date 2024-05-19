<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="courses and exams details.aspx.cs" Inherits="WebApplication1.courses_and_exams_details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <body>
<form id="form1" runat="server">
        <div>
             <asp:Label ID="Label21" runat="server" Text="Student ID:"></asp:Label>
            <br />
            <asp:TextBox ID="cc" runat="server"></asp:TextBox>
            <br />
        <asp:Button ID="Button1" runat="server" Text="Done" OnClick="Button1_Click" />
               <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
