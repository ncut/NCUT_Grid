using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;

namespace demo.UserControl
{
    public partial class CO2_OverView_Chart : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess(ConfigurationManager.ConnectionStrings["EMIMSConnectionString"].ConnectionString);
            SqlDataReader myReader = da.ReadDataFromTable("[5min]");

            Chart1.DataBindCrossTable(myReader, "传感器编号", "小时", "数据值", null);
            myReader.Close();

            // Set series appearance
            MarkerStyle marker = MarkerStyle.None;
            foreach (Series ser in Chart1.Series)
            {
                ser.ShadowOffset = 2;
                ser.BorderWidth = 3;
                ser.ChartType = SeriesChartType.Line;
                ser.MarkerSize = 12;
                ser.MarkerStyle = marker;
                ser.MarkerBorderColor = Color.FromArgb(64, 64, 64);
                ser.Font = new Font("Trebuchet MS", 8, FontStyle.Bold);
                marker++;
            }
        }
    }
}