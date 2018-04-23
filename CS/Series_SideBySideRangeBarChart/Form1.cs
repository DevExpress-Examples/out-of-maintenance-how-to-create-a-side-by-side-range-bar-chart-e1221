using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_SideBySideRangeBarChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl rangeBarChart = new ChartControl();

            // Create two range bar series.
            Series series1 = new Series("Series 1", ViewType.SideBySideRangeBar);
            Series series2 = new Series("Series 2", ViewType.SideBySideRangeBar);

            // Add points to them.
            series1.Points.Add(new SeriesPoint("A", 10, 15));
            series1.Points.Add(new SeriesPoint("B", 4, 7));
            series1.Points.Add(new SeriesPoint("C", 3, 13));
            series1.Points.Add(new SeriesPoint("D", 2, 11));
            series1.Points.Add(new SeriesPoint("E", 1, 8));

            series2.Points.Add(new SeriesPoint("A", 9, 13));
            series2.Points.Add(new SeriesPoint("B", 5, 10));
            series2.Points.Add(new SeriesPoint("C", 1, 9));
            series2.Points.Add(new SeriesPoint("D", 3, 7));
            series2.Points.Add(new SeriesPoint("E", 2, 10));

            // Add both series to the chart.
            rangeBarChart.Series.AddRange(new Series[] { series1, series2 });

            // Hide labels of the first both series.
            series1.Label.Visible = false;

            // Access the view-type-specific options of the series.
            SideBySideRangeBarSeriesView myView1 = (SideBySideRangeBarSeriesView)series1.View;
            myView1.MaxValueMarker.Visible = true;
            myView1.MinValueMarker.Visible = true;
            myView1.MinValueMarker.Kind = MarkerKind.Circle;
            myView1.MinValueMarker.Kind = MarkerKind.Circle;
            myView1.MaxValueMarker.Kind = MarkerKind.Star;
            myView1.MaxValueMarker.StarPointCount = 5;
            ((SideBySideRangeBarSeriesView)series2.View).BarWidth = 0.4;

            // Access the type-specific options of the diagram.
            ((XYDiagram)rangeBarChart.Diagram).Rotated = true;

            // Hide the legend (if necessary).
            rangeBarChart.Legend.Visible = false;

            // Add a title to the chart (if necessary).
            rangeBarChart.Titles.Add(new ChartTitle());
            rangeBarChart.Titles[0].Text = "A Side-by-Side Range Bar Chart";
            rangeBarChart.Titles[0].WordWrap = true;

            // Add the chart to the form.
            rangeBarChart.Dock = DockStyle.Fill;
            this.Controls.Add(rangeBarChart);
        }
    }
}