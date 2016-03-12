<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherForecast.aspx.cs" Inherits="FinalWebApplication.WeatherForecast" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 376px;
        }
    </style>
</head>
<body style="height: 370px">
    <form id="form1" runat="server">
    <div>
    
    </div>
        Get the Forecast details<br />
        <br />
        Enter the zipcode:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Forecast Details" />
        <asp:BulletedList ID="BulletedList1" runat="server">
        </asp:BulletedList>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go to Home Page" />
    </form>
</body>
</html>
