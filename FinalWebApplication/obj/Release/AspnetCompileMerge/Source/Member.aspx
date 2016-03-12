<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="FinalWebApplication.Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 434px;
        }
    </style>
</head>
<body style="height: 417px">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Login Page"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="User Name: "></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login as User" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Login as Staff" />
        <br />
        &nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Signup as Staff" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </form>
</body>
</html>
