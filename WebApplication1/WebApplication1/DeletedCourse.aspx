
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeletedCourse.aspx.cs" Inherits="project.DeletedCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             Course id:<br />
&nbsp;<asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            
        </div>
        <p>
            
            <asp:Button ID="Button1" runat="server" OnClick="coursed" Text="Delete Course" />
            
        </p>
    </form>
</body>
</html>
