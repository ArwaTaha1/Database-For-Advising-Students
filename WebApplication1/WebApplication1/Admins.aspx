<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admins.aspx.cs" Inherits="project.Admins" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="DeletingCourse" />
        </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="DeletingSlot" />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Adding Makeup Exam" />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Payment Details" />
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Installments Details" />
        <br />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Updating Status" />
        <br />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Active Student Details" />
        <br />
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Graduation Plan" />
        <br />
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Student Transcript" />
        <br />
        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Offered Courses Semester" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
