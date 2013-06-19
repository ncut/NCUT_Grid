using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo.UserControl
{
    public partial class Sensor_Option : System.Web.UI.UserControl
    {

        public string GetAcc()
        {
            return String.Format("[{0}]",DD_Acc.SelectedItem.Text);
        }
        public string GetDatePeriod()
        {
            string TimePieroYear=string.Empty,
                TimePieroDay=string.Empty,
                TimePieroMonth=string.Empty,
                TimePieroHour=string.Empty;
            string Result = "";
            switch (DD_Acc.SelectedIndex)
            {
                case 0:
                    TimePieroYear = String.Format("'{0}' and '{1}'", DD_StarYear.SelectedItem.Text, DD_EndYear.SelectedItem.Text);
                    Result += String.Format("[年] between {0}",TimePieroYear);
                    break;
                case 1:
                    TimePieroMonth = String.Format("'{0}' and '{1}'", DD_StartMonth.SelectedItem.Text, DD_EndMonth.SelectedItem.Text);
                    Result += String.Format("[月] between {0} and ",TimePieroMonth);
                    goto case 0;
                case 2:
                    TimePieroDay = String.Format("'{0}' and '{1}'", DD_StartDay.SelectedItem.Text, DD_EndDay.SelectedItem.Text);
                    Result += String.Format("[日] between {0} and ", TimePieroDay);
                    goto case 1;
                case 3:
                    TimePieroHour = String.Format("'{0}' and '{1}'", DD_StartTime.SelectedIndex.ToString(), DD_EndTime.SelectedIndex.ToString());
                    Result += String.Format("[小时] between {0} and ", TimePieroHour);
                    goto case 2;
                //case 3:
                //    Result = String.Format("'{0}-{1}-{2} {3}:00.000' and '{4}-{5}-{6} {7}:59.999'",
                //        DD_StarYear.SelectedItem.Text, DD_StartMonth.SelectedItem.Text, DD_StartDay.SelectedItem.Text, DD_StartTime.SelectedItem.Text,
                //        DD_EndYear.SelectedItem.Text, DD_EndMonth.SelectedItem.Text, DD_EndDay.SelectedItem.Text, DD_EndTime.SelectedItem.Text);
                //    break;
                default:
                    break;
            }
            return Result;
        }
        protected void Page_init()
        {
            DD_StarYear.SelectedIndex = DD_StarYear.Items.IndexOf(DD_StarYear.Items.FindByText(DateTime.Now.Year.ToString()));
            DD_StartMonth.SelectedIndex = DD_StartMonth.Items.IndexOf(DD_StartMonth.Items.FindByText(DateTime.Now.Month.ToString()));
            DD_StartDay.SelectedIndex = DD_StartDay.Items.IndexOf(DD_StartDay.Items.FindByText(DateTime.Now.Day.ToString()));

            DD_EndYear.SelectedIndex = DD_EndYear.Items.IndexOf(DD_EndYear.Items.FindByText(DateTime.Now.Year.ToString()));
            DD_EndMonth.SelectedIndex = DD_EndMonth.Items.IndexOf(DD_EndMonth.Items.FindByText(DateTime.Now.Month.ToString()));
            DD_EndDay.SelectedIndex = DD_EndDay.Items.IndexOf(DD_EndDay.Items.FindByText(DateTime.Now.Day.ToString()));
            DD_Acc.SelectedIndex = 3;
            DD_EndTime.SelectedIndex = 23;
            //DD_EndYear.Enabled = false;
            //DD_EndMonth.Enabled = false;
            //DD_EndDay.Enabled = false;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                Page_init();
            }
            

        }       
        protected void DD_Acc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DD_StarYear.Enabled = DD_Acc.SelectedIndex > -1 ? true : false;
            //DD_EndYear.Enabled=DD_Acc.SelectedIndex == 0 ? true : false;
            DD_EndYear.Enabled=DD_Acc.SelectedIndex > -1 ? true : false;
            DD_StartMonth.Enabled = DD_Acc.SelectedIndex > 0 ? true : false;
            //DD_EndMonth.Enabled = DD_Acc.SelectedIndex == 1 ? true : false;
            DD_EndMonth.Enabled = DD_Acc.SelectedIndex > 0 ? true : false;
            DD_StartDay.Enabled = DD_Acc.SelectedIndex > 1 ? true : false;
            //DD_EndDay.Enabled = DD_Acc.SelectedIndex == 2 ? true : false;
            DD_EndDay.Enabled = DD_Acc.SelectedIndex > 1 ? true : false;
            DD_StartTime.Enabled = DD_Acc.SelectedIndex > 2 ? true : false;
            //DD_EndTime.Enabled = DD_Acc.SelectedIndex == 3 ? true : false;
            DD_EndTime.Enabled = DD_Acc.SelectedIndex > 2 ? true : false;
        }
        protected void AddChart_Opt(string ControlPath)
        {
            Control control = LoadControl(ControlPath);
            control.ID = "SenChart";
            this.Parent.FindControl("PlaceHolder_Chart").Controls.Add(control);
        }
        protected void Bt_Show_Click(object sender, EventArgs e)
        {
            string base_dir = "~/UserControl/";
            string ControlPath = Page.Request.QueryString["senchart"];
            if (ControlPath != null)
            {
                if (ControlPath.Length > 0)
                {
                    AddChart_Opt(base_dir + ControlPath);
                }
            }
        }

    }
}