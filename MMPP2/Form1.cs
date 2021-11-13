using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace MMPP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Chart chart = new Chart();
            chart.Name = "DrawChart";
            chart.Location = new Point(16, 280);// 16 220 
            chart.Size = new Size(350, 350);
            //chart.MouseWheel += chart1_MouseWheel;
            //toolTip.SetToolTip(chart, "А graph for drawing numbers and their interactions");
            ////
            ChartArea chartArea = new ChartArea("ChartArea1");
            chart.ChartAreas.Add(chartArea);

            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisY.Interval = 1;
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            chart.ChartAreas[0].AxisX.IsMarginVisible = false;
            chart.ChartAreas[0].AxisY.IsMarginVisible = false;//default false?

            //s1
            Series series1 = new Series("Series1");
            series1.ChartType = SeriesChartType.Bar;
            chart.Series.Add(series1);
            chart.Series[0].BorderWidth = 5;

            series1.Points.AddXY(1,1);
            //s1

            this.Controls.Add(chart);
        }
    }
}
