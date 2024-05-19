<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="selectwhattoview.aspx.cs" Inherits="WebApplication1.selectwhattoview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Graduation Plan" OnClick="Button1_Click" Width="422px" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="upcoming unpaid installmnet" OnClick="Button2_Click" Width="422px" />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Courses and exam details " OnClick="Button3_Click" Width="422px" />
            <br />
            <asp:Button ID="Button4" runat="server" Text="All Courses and slots and details" OnClick="Button4_Click" Width="423px" />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Slots of certain instrusctor and Course" OnClick="Button5_Click" Width="423px" />
            <br />
            <asp:Button ID="Button6" runat="server" Text="Details of course and its prerequisites" OnClick="Button6_Click" Width="423px" />
        </div>
    </form>
</body>
</html>
