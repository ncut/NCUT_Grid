using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace demo.UserControl
{
    public partial class Navigationt : System.Web.UI.UserControl
    {
        protected void BuidNav()
        {
            string config = ConfigurationManager.AppSettings["ChartList"].Replace("\r\n","").Replace(" ",""); //二氧化碳:传感器4:Sensor4_Chart1.ascx;二氧化碳:传感器11:Sensor2_Chart.ascx

            string cat = Page.Request.QueryString["type"];
            string BaseUrl = HttpContext.Current.Request.Url.AbsoluteUri.Split('?')[0];
            TreeNode root = new TreeNode(cat);
            root.NavigateUrl = HttpContext.Current.Request.Url.AbsoluteUri + "#";

            string[] SensorList = config.Split(';');
            foreach (string item in SensorList)
            {
                string[] DetailList = item.Split(':');
                if (DetailList[0] == Server.UrlDecode(cat))
                {
                    TreeNode sensor = new TreeNode(DetailList[1]);
                    sensor.NavigateUrl = BaseUrl + "?type=" + cat + "&senchart=" + DetailList[2] + "&senID="+DetailList[3];
                    root.ChildNodes.Add(sensor);
                }
            }
            TreeView_Nav.Nodes.Add(root);


            //Following is Group by Location
            TreeNode Loca_root = new TreeNode("采集位置");
            Dictionary<string,TreeNode> map = new Dictionary<string,TreeNode> ();

            foreach (string item in SensorList)
            { 
                string[] Detailist=item.Split(':');
                if (Detailist[0] == Server.UrlDecode(cat))
                {
                    if (!map.Keys.Contains(Detailist[4]))
                    {
                        map.Add(Detailist[4], new TreeNode(Detailist[4]));
                        map[Detailist[4]].CollapseAll();
                    }
                }
            }

            foreach (string  item in SensorList)
            {
                string[] Detailist = item.Split(':');
                if (Detailist[0] == Server.UrlDecode(cat))
                {
                    map[Detailist[4]].ChildNodes.Add(new TreeNode(Detailist[1]));
                }
            }

            foreach (KeyValuePair<string,TreeNode> item in map)
            {
                Loca_root.ChildNodes.Add(item.Value);
            }

            TreeView_loca.Nodes.Add(Loca_root);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BuidNav();
            }
        }
    }
}