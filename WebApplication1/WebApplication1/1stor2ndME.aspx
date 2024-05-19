<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1stor2ndME.aspx.cs" Inherits="WebApplication1._1stor2ndME" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700">
            <asp:Button ID="Button1" runat="server" Text="1st Makeup" OnClick="Button1_Click" Width="518px" />
            <asp:Button ID="Button2" runat="server" Text="2nd Makeup" OnClick="Button2_Click" Width="618px" />
            <br />
            Student ID
            <br />
            <asp:TextBox ID="StudentId" runat="server" ></asp:TextBox>
            <br />
            Course ID<br />
            <asp:TextBox ID="CourseId" runat="server" ></asp:TextBox>
            <br />
            Student Current semester<br />
            <asp:TextBox ID="Currentsem" runat="server" ></asp:TextBox>
            </div>
    </form>
</body>
</html>
