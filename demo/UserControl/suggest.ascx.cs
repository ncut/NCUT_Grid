using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo.UserControl
{
    public partial class suggest : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cat = Page.Request.QueryString["type"]; 
            if(cat=="二氧化碳")
            {
                LbStandardValueMin.Text="0";
                LbStandardValueMax.Text="500";
            }
            Calendar1.Style.Add("display", "none");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Calendar1.Style.Add("display", "");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label_Date.Text = Calendar1.SelectedDate.Date.ToShortDateString();
            LbCurrentValue.Text = "    当日"+Page.Request.QueryString["type"]+ "的浓度为355";
            LbSuggest.Text = "空气质量良好，适合户外运动。";
            Calendar1.Style.Add("display", "none");
        }
    }

}