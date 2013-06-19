<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CO2_OverView_Chart.ascx.cs" Inherits="demo.UserControl.CO2_OverView_Chart" %>
<asp:Chart ID="Chart1" runat="server">
    <Series>
        <asp:Series ChartType="Line" Name="Series1">
        </asp:Series>
    </Series>
    <ChartAreas>
        <asp:ChartArea Name="ChartArea1">
        </asp:ChartArea>
    </ChartAreas>
</asp:Chart>

