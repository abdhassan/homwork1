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
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="1"></asp:Label>
            <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="2"></asp:Label>
            <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Butset_Click1" Text="set" />
            <asp:Button ID="Button3" runat="server" OnClick="Butget_Click" Text="get" />
            <br />
            <br />
            <br />
            <br>
        </div>
    </form>
</body>
</html>
