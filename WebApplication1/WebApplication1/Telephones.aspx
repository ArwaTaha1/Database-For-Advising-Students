<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Telephones.aspx.cs" Inherits="arwa.Telephones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please insert your ID to add a new phone number
            <br />
            <br />
            Student ID<br />
            <asp:TextBox ID="sID" runat="server"></asp:TextBox>
            <br />
            <br />
            Phone Number<br />
            <asp:TextBox ID="phoneNumber" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" OnClick="add" runat="server" Text="Add" />
        </div>
    </form>
</body>
</html>
