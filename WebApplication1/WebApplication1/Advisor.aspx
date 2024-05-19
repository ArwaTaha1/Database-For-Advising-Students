<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advisor.aspx.cs" Inherits="WebApplication1.Advisor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="View_Advising_Students" Text="View Advising Students" /> <div>&nbsp;</div>
            <asp:Button ID="Button2" runat="server" OnClick="Insert_graduation_plan" Text="Insert graduation plan" /><div>&nbsp;</div>
            <asp:Button ID="Button3" runat="server" OnClick="Insert_courses_for_a_graduation_plan" Text="Insert courses for a graduation plan" />
        </div>
        <div>&nbsp;</div>
        <div>
            <asp:Button ID="Button4" runat="server" OnClick="Update_expected_graduation_date" Text="Update expected graduation date in a certain graduation plan" /><div>&nbsp;</div>
            <asp:Button ID="Button5" runat="server" OnClick="Delete_course_from_graduation_plan" Text="Delete course from a certain graduation plan" /><div>&nbsp;</div>
            <asp:Button ID="Button6" runat="server" OnClick="View_students_assigned_from_certain_major_with_their_courses" Text="View all students assigned to you from a certain major along with their taken courses" /><div>&nbsp;</div>
            <asp:Button ID="Button7" runat="server" OnClick="View_all_requests" Text="View all requests" /><div>&nbsp;</div>
            <asp:Button ID="Button8" runat="server" OnClick="View_all_pending_requests" Text="View all pending requests" /><div>&nbsp;</div>
            <asp:Button ID="Button9" runat="server" OnClick="Approve_reject_extra_credit_hours_request" Text="Approve/ reject extra credit hours request" /><div>&nbsp;</div>
            <asp:Button ID="Button10" runat="server" OnClick="Approve_reject_extra_courses_request" Text="Approve/ reject extra courses request" /></div>
    </form>
</body>
</html>
