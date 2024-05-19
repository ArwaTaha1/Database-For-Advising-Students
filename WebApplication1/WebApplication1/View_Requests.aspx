<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Requests.aspx.cs" Inherits="WebApplication1.View_Requests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Enter Your ID: <asp:TextBox ID="aid" runat="server"></asp:TextBox>
            <asp:Button ID="update" runat="server" OnClick="View" Text="View" />
            <div>&nbsp;</div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True" CssClass="table table-striped table-bordered"></asp:GridView>
        </div>
    </form>
</body>
</html>
