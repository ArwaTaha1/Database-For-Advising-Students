<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update_Plan.aspx.cs" Inherits="WebApplication1.Update_Plan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Enter The Following Details:
        </div>
        <div>&nbsp;</div>
        <div>
          Student's ID:  <asp:TextBox ID="sid" runat="server"></asp:TextBox>&nbsp;</div>
        <div>&nbsp;</div>
        <div>
            Expected Graduation Date: 
    <div>&nbsp;</div>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></div>    <div>&nbsp;</div>
        <asp:Button ID="update" runat="server" OnClick="Insert" Text="Update" />
    </form>
</body>
</html>
