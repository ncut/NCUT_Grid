<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="demo.WebForm1" %>
<%@ Register src="UserControl/Navigationt.ascx" tagname="Navigationt" tagprefix="uc2" %>

<%@ Register src="UserControl/Sensor_Option.ascx" tagname="Sensor_Option" tagprefix="uc1" %>

<%@ Register src="UserControl/find1.ascx" tagname="find1" tagprefix="uc3" %>

<%@ Register src="UserControl/findl2.ascx" tagname="findl2" tagprefix="uc4" %>

<%@ Register src="UserControl/find3.ascx" tagname="find3" tagprefix="uc5" %>


<%@ Register src="UserControl/suggest.ascx" tagname="suggest" tagprefix="uc6" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 20px;
        }
        .style3
        {
            width: 733px;
        }
        .style5
        {
            height: 20px;
            width: 1001px;
        }
    </style>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" width="100%" align="center">
    <div style="width:1001px;margin:0 auto;background-color:#0f0">
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/header.jpg" />
    
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div style="width:1001px;margin:0 auto;background-color:#081;">
        <table style="width: 1001px">
            <tr>
                <td width="50">
                </td>
                <td class="style1" align="left">
                    首钢老工业区环境监测系统</td>
                <td align="center" style="text-align: right">
                    <asp:Label ID="lbDate" runat="server" Enabled="False" Font-Names="微软雅黑" 
                        Width="360px" style="text-align: right"></asp:Label>
                    <asp:HyperLink ID="hlInformation" runat="server" Font-Names="微软雅黑" 
                        NavigateUrl="~/Information.aspx">联系我们</asp:HyperLink>
                </td>
            </tr>
        </table>
    </div>
    <div style="width:1001px;margin:0 auto;background-color:#fff;">
        <table style="width: 100%; background-image: url('images/bakground.jpg');" 
            align="center">
            <tr>
                <td style="border: thick groove #008000; height: 600px; width: 220px;padding-top:40px; padding-left:20px" 
                    align="left" valign="top">
                    <uc2:Navigationt ID="Navigationt1" runat="server" ClientIDMode="Predictable" />
                    <asp:PlaceHolder ID="PlaceHolder_Nav" runat="server"></asp:PlaceHolder>
                    <br />
                    <asp:Label ID="Label2" runat="server" Enabled="False" Font-Names="微软雅黑" 
                        Width="260px" Font-Size="11pt" Height="193px"><p style="margin-top:14px;text-indent:2em">空气质量的好坏反映了空气污染程度，它是依据空气中污染物浓度的高低来判断的。</p><p style="text-indent:2em">空气污染是一个复杂的现象，在特定时间和地点空气污染物浓度受到许多因素影响。</p><p style="text-indent:2em">来自固定和流动污染源的人为污染物排放大小是影响空气质量的最主要因素之一，其中包括车辆、船舶、飞机的尾气、工业企业生产排放、居民生活和取暖、垃圾焚烧等。</p><p style="text-indent:2em">城市的发展密度、地形地貌和气象等也是影响空气质量的重要因素。</p></asp:Label>
                </td>
                <td style="padding-left:10px; vertical-align: top; padding-top: 20px; " 
                    align="left" valign="top" 
                    class="style3">
                    <div style="width:727px;height:404px">                  
                    <asp:PlaceHolder ID="PlaceHolder_Chart" runat="server"></asp:PlaceHolder>
                    </div>
                    <hr />
                    
                    <uc4:findl2 ID="findl21" runat="server" /><br />
                    <uc3:find1 ID="find11" runat="server" /><br />
                    <uc5:find3 ID="find31" runat="server" /><br />

                    <uc1:Sensor_Option ID="Sensor_Option1" runat="server" />
                      <hr />

                    <uc6:suggest ID="suggest1" runat="server" />
                    <br />

                </td>
                
            </tr>

            
        </table>
        <table style="width:auto;">
            <tr>
                <td class="style5" align="center" style="background-color: #081">
                    <asp:Label ID="Label1" runat="server" Text="北方工业大学  无线传感器实验室  地址：北京市石景山区晋元庄路5号" 
                        Font-Names="微软雅黑"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
