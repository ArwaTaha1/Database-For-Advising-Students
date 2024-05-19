<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="spage4.aspx.cs" Inherits="Advising_Team_7.spage4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            insert the date in the mm-dd-yyyy format<br />
            Start date<br />
            <br />
            <asp:TextBox ID="start" runat="server"></asp:TextBox>
            <br />
            end date<br />
            <asp:TextBox ID="end" runat="server" style="margin-bottom: 13px"></asp:TextBox>
            <br />
            <br />
            semester code<br />
            <asp:TextBox ID="code" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Enter" OnClick="page23" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Back" OnClick="mainn" />
            <br />
        </div>
    </form>
</body>
</html>
