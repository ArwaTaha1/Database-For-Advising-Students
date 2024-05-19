<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="spage6.aspx.cs" Inherits="Advising_Team_7.spage6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            all inputs should be an integer<br />
            instructor id<br />
            <asp:TextBox ID="iid" runat="server"></asp:TextBox>
            <br />
            course id<br />
            <br />
            <asp:TextBox ID="sid" runat="server" ></asp:TextBox>
            <br />
            <br />
            Slot id<br />
            <br />
            <asp:TextBox ID="slid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Enter" OnClick="page23" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Back" OnClick="mainn" />
            <br />
        </div>
    </form>
</body>
</html>
