<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="makeup.aspx.cs" Inherits="project.makeup1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Type:<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>First_makeup</asp:ListItem>
            <asp:ListItem>Second_makeup</asp:ListItem>
        </asp:DropDownList>
&nbsp;<p>
        </p>
        
      Date: <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar><p>
        &nbsp;</p>
       Course ID: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

        <asp:Button ID="Button1" runat="server" OnClick="makeupexaminsertion" Text ="AddMakeupExam" />
         <p>
 </p>
    </form>
</body>
</html>
