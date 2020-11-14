<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="field.aspx.cs" Inherits="taqanat.field" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="set" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="get" />
        <asp:HiddenField ID="HiddenField1" runat="server" Value="oo" />
    
    </div>
    </form>
</body>
</html>
