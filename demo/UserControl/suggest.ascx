<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="suggest.ascx.cs" Inherits="demo.UserControl.suggest" %>
<div class="queryTime" style="font-family:微软雅黑;font-size:16px"  >
    <asp:Label ID="Label1" runat="server" Text="户外运动指数" Font-Bold="True"></asp:Label>
    <br />
</div>
<div style="font-family:微软雅黑;font-size:16px">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">选择日期</asp:LinkButton>
            :<asp:Calendar ID="Calendar1" runat="server" 
                onselectionchanged="Calendar1_SelectionChanged"></asp:Calendar>
            <asp:Label ID="Label_Date" runat="server"></asp:Label>
            <asp:Label ID="LbCurrentValue" runat="server" Text=""></asp:Label>
    <br />
    <br />
            <asp:Label ID="LbCompare" runat="server" Text="适宜运动范围： "></asp:Label>
            <asp:Label ID="LbStandardValueMin" runat="server" Text=""></asp:Label>
            至 
            <asp:Label ID="LbStandardValueMax" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="LbSuggest" runat="server" Text=""></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
</div>