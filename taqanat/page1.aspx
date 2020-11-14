<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="taqanat.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>this is page one</p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br>
            <asp:Button ID="Button2" runat="server" Text="go to page2" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:TextBox ID="name" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            <br />
            <asp:TextBox ID="lastname" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="submit" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
