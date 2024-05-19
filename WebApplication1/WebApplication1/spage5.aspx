<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="spage5.aspx.cs" Inherits="Advising_Team_7.spage5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        semester and credit hours should be an integer</p>
    <p>
        offered should be 1 or 0 (1 for offered and 0 for not)</p>
    <form id="form1" runat="server">
        <div>
            major<br />
            <asp:TextBox ID="major" runat="server"></asp:TextBox>
            <br />
            semester<br />
            <asp:TextBox ID="semester" runat="server"></asp:TextBox>
            <br />
            credit hours<br />
            <asp:TextBox ID="credithours" runat="server"></asp:TextBox>
            <br />
            course name<br />
            <asp:TextBox ID="coursename" runat="server"></asp:TextBox>
            <br />
            offered<br />
            <asp:TextBox ID="offered" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" Text="Enter" OnClick="page23" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Back" OnClick="mainn" />
            <br />
        </div>
    </form>
</body>
</html>
