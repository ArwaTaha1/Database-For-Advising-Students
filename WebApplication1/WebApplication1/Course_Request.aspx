<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Course_Request.aspx.cs" Inherits="WebApplication1.Course_Request" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div>
         Please Insert The Following Details: <div>&nbsp;</div>

        Request ID: <asp:TextBox ID="id" runat="server"></asp:TextBox>
            <div>&nbsp;</div>
        Current Semester Code: <asp:TextBox ID="sc" runat="server"></asp:TextBox>
            <div>&nbsp;</div>
            <asp:Button ID="Button1" runat="server" OnClick="insert" Text="Update" />
        </div>
    </form>
</body>
</html>
