<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffHome.aspx.cs" Inherits="FinalWebApplication.StaffHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 333px">
    
        <br />
        <asp:Button ID="Button1" runat="server" Height="129px" Text="Get wind Intensity" Width="175px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="129px" Text="View Admin Page" Width="175px" OnClick="Button2_Click" />
    
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Go to Home" />
    
    </div>
    </form>
</body>
</html>
