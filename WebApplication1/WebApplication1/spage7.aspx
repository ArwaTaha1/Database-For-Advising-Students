<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="spage7.aspx.cs" Inherits="Advising_Team_7.spage7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            ids should be integers</p>
        <p>
            Student ID</p>
        <p>
            <asp:TextBox ID="sid" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            Advisor ID</p>
        <asp:TextBox ID="aid" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" Text="Enter" OnClick="page23" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="Back" OnClick="mainn" />
        <br />
        <div>
        </div>
    </form>
</body>
</html>
