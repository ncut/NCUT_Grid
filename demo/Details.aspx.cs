using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void AddChart(string ControlPath)
        {
            Control control = LoadControl(ControlPath);
            control.ID = "SenChart";
            this.PlaceHolder_Chart.Controls.Add(control);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string base_dir = "~/UserControl/";
            if (!Page.IsPostBack)
            {
                this.lbDate.Text = "今天是:" + System.DateTime.Now.ToShortDateString();
                //Navigationt1.VerticalAlignment = VerticalAlignment.Top;
                string ControlPath = Page.Request.QueryString["senchart"];
                if (ControlPath != null)
                {
                    if (ControlPath.Length > 0)
                    {
                        AddChart(base_dir + ControlPath);
                    }
                }
                
            }
            
        }
    }
}