<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Advising_Team_7.admin" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="List all advisors" OnClick="page11"/>
        <p>
            <asp:Button ID="Button2" runat="server" Text="List all students with their advisors"  OnClick="page2"/>
        </p>
        <p>
            &nbsp;<asp:Button ID="Button3" runat="server" Text="List all Pending Requests"  OnClick="page3"/>
        </p>
        <asp:Button ID="Button4" runat="server" Text="Add new semester"  OnClick="page4"/>
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="Add new Course" OnClick="page5" />
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" Text="link instructor to a course in slot"  OnClick="page6"/>
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" Text="Link a student to a advisor"  OnClick="page7"/>
        <br />
        <br />
        <asp:Button ID="Button8" runat="server" Text="link student to a course with a specific instructor" OnClick="page8" />
        <br />
        <br />
        <asp:Button ID="Button9" runat="server" Text="View all details of instructors with their assighned courses"  OnClick="page9"/>
        <br />
        <br />
        <asp:Button ID="Button10" runat="server" Text="Fetch all semesters along with their  offered courses"  OnClick="page10"/>
        <br />
        <br />
        <asp:Button ID="Button11" runat="server" Text="Next"  OnClick="Next"/>

        <br />
        <br />
        <br />
    </form>
</body>
</html>
