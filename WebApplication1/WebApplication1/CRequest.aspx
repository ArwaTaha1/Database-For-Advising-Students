<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRequest.aspx.cs" Inherits="arwa.CRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Send Course Request<br />
            <br />
            Student ID
            <br />
            <asp:TextBox ID="sID" runat="server"></asp:TextBox>
            <br />
            <br />
            Course ID<br />
            <asp:TextBox ID="cID" runat="server"></asp:TextBox>
            <br />
            <br />
            Type<br />
            <asp:TextBox ID="type" runat="server"></asp:TextBox>
            <br />
            <br />
            Comment<br />
            <asp:TextBox ID="comment" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" OnClick ="send" runat="server" Text="Send" />
        </p>
    </form>
</body>
</html>
