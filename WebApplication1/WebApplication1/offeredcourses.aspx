<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="offeredcourses.aspx.cs" Inherits="project.offeredcourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="coursesoffered" Text="TheOfferedCourses" />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
