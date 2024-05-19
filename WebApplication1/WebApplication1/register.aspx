<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="arwa.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student Registeration</div>
        <p>
            First Name
        </p>
        <p>
            <asp:TextBox ID="first_name" runat="server" ></asp:TextBox>
        </p>
        <p>
            Last Name </p>
        <p>
            <asp:TextBox ID="last_name" runat="server" style="margin-bottom: 23px"></asp:TextBox>
        </p>
        <p>
            Password
        </p>
        <p>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
        </p>
        <p>
            Faculty
        </p>
        <p>
            <asp:TextBox ID="faculty" runat="server"></asp:TextBox>
        </p>
        <p>
            Email
        </p>
        <p>
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
        </p>
        <p>
            Major
        </p>
        <p>
            <asp:TextBox ID="major" runat="server"></asp:TextBox>
        </p>
        <p>
            Semester</p>
        <p>
            <asp:TextBox ID="semester" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick = "registerStudent" />
        </p>
    </form>
</body>
</html>
