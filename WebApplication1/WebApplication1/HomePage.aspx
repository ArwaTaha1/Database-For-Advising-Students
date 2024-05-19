<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="arwa.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose an Option From Below<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="add_phone" Text="Add Telephones" />
            <br />
            <br />
        </div>
        <asp:Button ID="Button2" runat="server" OnClick="view_optional" Text="View Optional Courses in Current Semester" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="view_all_courses" Text="View All Courses in Current Semester" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="view_required" Text="View Required Courses in Current Semester" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" OnClick ="view_missing" Text="View Missing Courses" />
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" OnClick ="send_course_request" Text="Send Course Request" />
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" OnClick ="send_CH_request" Text="Send Credit Hours Request" />
        <br />
        <br />
        <asp:Button ID="Button8" runat="server" OnClick ="Next" Text="Next" />

    </form>
</body>
</html>
