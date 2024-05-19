<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="spage8.aspx.cs" Inherits="Advising_Team_7.spage8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            all the ids should be integers &nbsp;</p>
        <p>
            Course ID<br />
            <asp:TextBox ID="cid" runat="server"></asp:TextBox>
        </p>
        <p>
            Instructor ID</p>
        <p>
            <asp:TextBox ID="iid" runat="server"></asp:TextBox>
        </p>
        <p>
            Student ID</p>
        <p>
            <asp:TextBox ID="sid" runat="server"></asp:TextBox>
        </p>
        <p>
            Semester Code</p>
        <p>
            <asp:TextBox ID="semm" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button6" runat="server" OnClick="page23" Text="Enter" />
    <br />
    <asp:Button ID="Button5" runat="server" Text="Back" OnClick="mainn" />
    <br />
        <div>
        </div>
    </form>
</body>
</html>
