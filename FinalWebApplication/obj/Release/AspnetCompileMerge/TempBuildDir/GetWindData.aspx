<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetWindData.aspx.cs" Inherits="FinalWebApplication.GetWindData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 389px">
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Get Wind Intensity"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Latitude: "></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Longitude: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Wind Intensity" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go to Home Page" />
    
    </div>
    </form>
</body>
</html>
