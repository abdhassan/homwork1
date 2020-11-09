<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page2.aspx.cs" Inherits="taqanat.page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>this is page two</p>
            <asp:CheckBox ID="CheckBox1" runat="server" /><br>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br>
        </div>
    </form>
</body>
</html>
