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
    public partial class WebUserControl_Chart1 : System.Web.UI.UserControl,IUpdateChart
    {
        private double[] findRange(DataPointCollection collection)
        {
            double[] range = new double[4];
            double minX=0, maxX=0, minY=0, maxY=0;
            int i = 0;
            foreach (DataPoint item in collection)
            {
                if (i==0)
                {
                    minX = item.XValue;
                    maxX = item.XValue;
                    minY = item.YValues[0];
                    maxY = item.YValues[0];
                    i++;
                }
                if (minX>item.XValue)
                {
                    minX = item.XValue;
                }
                if (maxX<item.XValue)
                {
                    maxX = item.XValue;
                }
                if (minY>item.YValues[0])
                {
                    minY = item.YValues[0];
                }
                if (maxY<item.YValues[0])
                {
                    maxY = item.YValues[0];
                }
            }
            range[0] = minX;
            range[1] = maxX;
            range[2] = minY;
            range[3] = maxY;
            return range;
        }
        public void Update()
        {
            string SenID= Page.Request.QueryString["senID"];
            Sensor_Option option = (Sensor_Option)this.Parent.FindControl("Sensor_Option1"); // this.Parent.FindControl(Sensor_Option)
            DataAccess da = new DataAccess(ConfigurationManager.ConnectionStrings["EMIMSConnectionString"].ConnectionString);

            SqlDataReader myReader = da.ReadDataFromTable("[EMIMS].[dbo].[监测信息视图]", option.GetAcc(), option.GetDatePeriod(), SenID);
            string xvalue = option.GetAcc().Replace("[","").Replace("]","");
            Chart1.DataBindCrossTable(myReader, "传感器编号",xvalue , "数值", null);
            
            myReader.Close();

            if (Chart1.Series.Count>1)
            {
                double[] range = findRange(Chart1.Series[1].Points);

                Chart1.ChartAreas[0].AxisX.Minimum = range[0];

                Chart1.ChartAreas[0].AxisX.Interval = 1;
                Chart1.ChartAreas[0].AxisY.Minimum = (int)(range[2] - 5);
                Chart1.ChartAreas[0].AxisY.Maximum = (int)(range[3] + 5);
            }
            
           

            // Set series appearance
            //Chart1.BackColor = Color.Transparent;
            //MarkerStyle marker = MarkerStyle.None;
            //foreach (Series ser in Chart1.Series)
            //{
            //    ser.ShadowOffset = 2;
            //    ser.BorderWidth = 1;
                //ser.ChartType = SeriesChartType.Line;
            //    ser.MarkerSize = 12;
            //    ser.MarkerStyle = marker;
            //    ser.MarkerBorderColor = Color.FromArgb(64, 64, 64);
            //    ser.Font = new Font("Trebuchet MS", 8, FontStyle.Bold);
            //    marker++;
            //}
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Update();

        }
    }
}