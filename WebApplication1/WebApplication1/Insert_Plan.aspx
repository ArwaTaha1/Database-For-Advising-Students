<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert_Plan.aspx.cs" Inherits="WebApplication1.Insert_Plan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Input The Following Details:
        </div>
        <div>&nbsp;</div>
        <div>
            ID: &nbsp; <asp:TextBox ID="id" runat="server"></asp:TextBox>&nbsp;</div>
        <div>
           Student's ID: <asp:TextBox ID="sid" runat="server"></asp:TextBox>&nbsp;</div>
        <div>
           Expected Graduation Date: <div>&nbsp;</div><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <div>
           Semester Code: <asp:TextBox ID="sc" runat="server"></asp:TextBox>&nbsp;</div>
        <div>
           Semester Credit Hours: <asp:TextBox ID="sch" runat="server"></asp:TextBox>&nbsp;</div><div>&nbsp;</div>
        <div>
            <asp:Button  ID="Button1" runat="server" OnClick="insert" Text="Insert"></asp:Button>&nbsp;</div>
    </form>
</body>
</html>
