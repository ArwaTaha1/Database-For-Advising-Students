<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="certain instrusctor and Course.aspx.cs" Inherits="WebApplication1.certain_instrusctor_and_Course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <body>
<form id="form1" runat="server">
        <div>
             <asp:Label ID="Label11" runat="server" Text="Instructor ID:"></asp:Label>
             <br />
            <br />
            <asp:TextBox ID="iid" runat="server"></asp:TextBox>
             <br />
            <br />
             <asp:Label ID="Label2" runat="server" Text="Course ID:"></asp:Label>
             <br />
             <br />
          <asp:TextBox ID="cid" runat="server"></asp:TextBox>
             <br />
             <br />
        <asp:Button ID="Button1" runat="server" Text="Done" OnClick="Button1_Click" />
             <br />
             <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
