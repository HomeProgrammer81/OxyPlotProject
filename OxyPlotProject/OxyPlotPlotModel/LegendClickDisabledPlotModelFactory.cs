using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;

namespace OxyPlotProject.OxyPlotPlotModel
{
    /// <summary>
    /// 凡例クリック無効PlotModelファクトリー
    /// </summary>
    internal class LegendClickDisabledPlotModelFactory : AbstPlotModelFactory
    {
        public override PlotModel Create()
        {
            // モデル
            PlotModel plotModel = new PlotModel();
            plotModel.Title = "サンプルグラフ";

            // ライン軸
            LinearAxis linearAxis = new LinearAxis();
            linearAxis.Position = AxisPosition.Bottom;
            plotModel.Axes.Add(linearAxis);

            // ライン
            LineSeries lineSeries = new LineSeries();
            lineSeries.Title = "サンプルライン";
            lineSeries.Points.Add(new DataPoint(0, 34));
            lineSeries.Points.Add(new DataPoint(10, 22));
            lineSeries.Points.Add(new DataPoint(20, 45));
            lineSeries.Points.Add(new DataPoint(30, 56));
            lineSeries.Points.Add(new DataPoint(40, 43));
            lineSeries.Points.Add(new DataPoint(50, 11));
            lineSeries.Points.Add(new DataPoint(60, 21));
            lineSeries.Points.Add(new DataPoint(70, 29));
            lineSeries.Points.Add(new DataPoint(80, 17));
            lineSeries.Points.Add(new DataPoint(90, 31));
            lineSeries.Points.Add(new DataPoint(100, 23));
            plotModel.Series.Add(lineSeries);

            // 凡例
            Legend legend = new Legend();
            legend.LegendSymbolLength = 30;
            legend.ShowInvisibleSeries = false;
            plotModel.Legends.Add(legend);

            return plotModel;
        }
    }
}
