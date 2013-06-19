<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navigationt.ascx.cs" Inherits="demo.UserControl.Navigationt" %>
<div id="nav">
<asp:TreeView ID="TreeView_Nav" runat="server" BorderStyle="None" 
        CollapseImageUrl="~/images/绿星星.jpg" Font-Names="微软雅黑" Font-Size="16px" 
        Width="126px">
    <HoverNodeStyle BackColor="#009933" BorderStyle="None" />
    <NodeStyle VerticalPadding="3px" />
    <ParentNodeStyle ChildNodesPadding="5px" HorizontalPadding="5px" />
    <RootNodeStyle ChildNodesPadding="0px" />
    <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" 
                            HorizontalPadding="0px" VerticalPadding="0px" />
</asp:TreeView></div>

                    <asp:TreeView ID="TreeView_loca" runat="server" CollapseImageUrl="~/images/绿星星.jpg" Font-Names="微软雅黑" Font-Size="16px" 
        Width="126px">
                        <HoverNodeStyle BackColor="#009933" BorderStyle="None" />
                        <NodeStyle VerticalPadding="3px" />
                        <ParentNodeStyle ChildNodesPadding="5px" HorizontalPadding="5px" />
                        <RootNodeStyle ChildNodesPadding="0px" />
                        <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" 
                            HorizontalPadding="0px" VerticalPadding="0px" />
                    </asp:TreeView>
                

