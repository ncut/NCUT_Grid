<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sensor7_Chart.ascx.cs" Inherits="demo.UserControl.Sensor7_Chart" %>
<asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1">
    <Series>
        <asp:Series Name="Series1" XValueMember="时间" YValueMembers="数据值">
        </asp:Series>
    </Series>
    <ChartAreas>
        <asp:ChartArea Name="ChartArea1">
        </asp:ChartArea>
    </ChartAreas>
</asp:Chart>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:EMIMSConnectionString %>" 
    SelectCommand="SELECT * FROM [监测信息视图] WHERE ([传感器编号] = @传感器编号)">
    <SelectParameters>
        <asp:Parameter DefaultValue="7" Name="传感器编号" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>

