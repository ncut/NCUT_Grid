<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sensor4_Chart1.ascx.cs" Inherits="demo.UserControl.WebUserControl_Chart1" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Chart ID="Chart1" runat="server" BackColor="Transparent" 
    BackImageTransparentColor="Transparent" Height="404px" Width="727px">
    <series>
        <asp:Series Name="Series1" ChartType="FastLine">
        </asp:Series>
    </series>
    <chartareas>
        <asp:ChartArea Name="ChartArea1">
        </asp:ChartArea>
    </chartareas>
</asp:Chart>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:EMIMSConnectionString %>" 
    SelectCommand="SELECT * FROM [监测信息视图] WHERE ([传感器编号] = @传感器编号)">
    <SelectParameters>
        <asp:Parameter DefaultValue="4" Name="传感器编号" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>