<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CHRequest.aspx.cs" Inherits="arwa.CHRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Send Credit Hours Request<br />
            <br />
            Student ID
            <br />
            <asp:TextBox ID="sID" runat="server"></asp:TextBox>
            <br />
            <br />
            Credit Hours
            <br />
            <asp:TextBox ID="CH" runat="server" > </asp:TextBox>
            <br />
            <br />
            Type
            <br />
            <asp:TextBox ID="type" runat="server"></asp:TextBox>
            <br />
            <br />
            Comment<br />
            <asp:TextBox ID="comment" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" OnClick ="send" runat="server" Text="Send" />
        </div>
    </form>
</body>
</html>
