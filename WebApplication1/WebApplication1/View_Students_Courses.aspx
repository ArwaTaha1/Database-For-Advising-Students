<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Students_Courses.aspx.cs" Inherits="WebApplication1.View_Students_Courses" %>

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
   ID :  <asp:TextBox ID="id" runat="server"></asp:TextBox>&nbsp;</div>
<div>&nbsp;</div>
<div> Major :  <asp:TextBox ID="m" runat="server"></asp:TextBox>&nbsp;</div>
<div>&nbsp;</div>
<asp:Button ID="update" runat="server" OnClick="View" Text="View" />
<div>&nbsp;</div>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True" CssClass="table table-striped table-bordered"></asp:GridView>

    </div>
    </form>
</body>
</html>
