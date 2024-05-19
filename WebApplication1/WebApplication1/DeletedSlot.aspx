<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeletedSlot.aspx.cs" Inherits="project.DeletedSlot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Current semster:<br />
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="slotdelete" runat="server" Onclick="dslot"  Text="Delete Slot" />
        </p>
    </form>
</body>
</html>
