<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete_Course_Plan.aspx.cs" Inherits="WebApplication1.Delete_Course_Plan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                    Please Enter The Following Details:
    <div>&nbsp;</div>
    <div>
      Student's ID :  <asp:TextBox ID="sid" runat="server"></asp:TextBox>&nbsp;</div>
    <div>&nbsp;</div>
    <div> Course ID :  <asp:TextBox ID="cid" runat="server"></asp:TextBox>&nbsp;</div>
    <div>&nbsp;</div>
    <div> Semester Code :  <asp:TextBox ID="sc" runat="server"></asp:TextBox>&nbsp;</div>
    <div>&nbsp;</div>
    <asp:Button ID="update" runat="server" OnClick="Delete" Text="Delete" />
        </div>
    </form>
</body>
</html>
