<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ImageVerifier.ascx.cs" Inherits="FinalWebApplication.ImageVerifier" %>
<asp:Image ID="Image1" runat="server" Height="80px" Width="204px" />
<p>
    &nbsp;</p>
<asp:Label ID="Label1" runat="server" Text="Please enter the string shown in image:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<p>
&nbsp;
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Load another Image" style="height: 29px" />
</p>

