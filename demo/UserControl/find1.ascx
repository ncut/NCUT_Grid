<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="find1.ascx.cs" Inherits="demo.UserControl.WebUserControl1" %>
<div style="font-family:微软雅黑; font-size:16px">
  
    <asp:Label ID="Label1" runat="server" Text="多传感器查询："></asp:Label>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label3" runat="server" Text="  传感器编号范围"></asp:Label>
    &nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Width="123px" Height="17px"></asp:TextBox> 
    &nbsp; 
    <asp:Label ID="Label2" runat="server" Text="至 "></asp:Label>  
&nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="17px" Width="123px"></asp:TextBox>

</div>