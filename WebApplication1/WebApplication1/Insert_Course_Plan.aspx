<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert_Course_Plan.aspx.cs" Inherits="WebApplication1.Insert_Course_Plan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Insert The Following Details: <div>&nbsp;</div>

       Student's ID: <asp:TextBox ID="id" runat="server"></asp:TextBox>
        </div>
        <div>&nbsp;</div>
       Semester Code: <asp:TextBox ID="sc" runat="server"></asp:TextBox>
        <div>&nbsp;</div>
        Course Name: <asp:TextBox ID="cn" runat="server"></asp:TextBox>
        <div>&nbsp;</div>
        <asp:Button ID="Button1" runat="server" OnClick="insert" Text="Insert" />
    </form>
</body>
</html>
