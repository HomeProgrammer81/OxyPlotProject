using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;

namespace OxyPlotProject.OxyPlotPlotModel
{
    /// <summary>
    /// X軸バープロットモデルファクトリー
    /// </summary>
    internal class XAxisBarPlotModelFactory : AbstPlotModelFactory
    {
        public override PlotModel Create()
        {
            // モデル
            PlotModel plotModel = new PlotModel();
            plotModel.Title = "サンプルグラフ";

            // カテゴリーX軸
            CategoryAxis xAxis = new CategoryAxis();
            xAxis.Position = AxisPosition.Bottom;
            xAxis.Key = "xAxis";
            plotModel.Axes.Add(xAxis);

            // ラインY軸
            LinearAxis yAxis = new LinearAxis();
            yAxis.Position = AxisPosition.Left;
            yAxis.Key = "yAxis";
            plotModel.Axes.Add(yAxis);

            // バー
            BarSeries barSeries = new BarSeries();
            barSeries.Title = "バー";
            barSeries.XAxisKey = "yAxis";
            barSeries.YAxisKey = "xAxis";
            barSeries.FillColor = OxyColors.Red;
            barSeries.StrokeThickness = 1;
            barSeries.StrokeColor = OxyColors.Black;
            barSeries.BarWidth = 50;

            barSeries.Items.Add(new BarItem() { Value = 10 });
            barSeries.Items.Add(new BarItem() { Value = 15 });
            barSeries.Items.Add(new BarItem() { Value = 13 });
            barSeries.Items.Add(new BarItem() { Value = 21 });
            barSeries.Items.Add(new BarItem() { Value = 32 });
            barSeries.Items.Add(new BarItem() { Value = 34 });
            barSeries.Items.Add(new BarItem() { Value = 45 });
            barSeries.Items.Add(new BarItem() { Value = 65 });
            barSeries.Items.Add(new BarItem() { Value = 64 });
            barSeries.Items.Add(new BarItem() { Value = 63 });
            barSeries.Items.Add(new BarItem() { Value = 70 });
            plotModel.Series.Add(barSeries);

            // 凡例
            Legend legend = new Legend();
            legend.LegendSymbolLength = 30;
            legend.LegendPosition = LegendPosition.TopLeft;
            plotModel.Legends.Add(legend);

            return plotModel;

        }
    }
}
