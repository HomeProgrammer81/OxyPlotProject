using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxyPlotProject.OxyPlotPlotModel
{
    /// <summary>
    /// 棒グラフ 重ねるプロットモデルファクトリー
    /// </summary>
    internal class BarOverWritePlotModelFactory : AbstPlotModelFactory
    {
        public override PlotModel Create()
        {
            // モデル
            PlotModel plotModel = new PlotModel();
            plotModel.Title = "商品-売上サンプル";

            // カテゴリーX軸
            CategoryAxis xAxis = new CategoryAxis();
            xAxis.Position = AxisPosition.Bottom;
            xAxis.Key = "xAxis";
            xAxis.Labels.Add("1月");
            xAxis.Labels.Add("2月");
            xAxis.Labels.Add("3月");
            xAxis.Labels.Add("4月");
            xAxis.Labels.Add("5月");
            xAxis.Labels.Add("6月");
            xAxis.Labels.Add("7月");
            xAxis.Labels.Add("8月");
            xAxis.Labels.Add("9月");
            xAxis.Labels.Add("10月");
            xAxis.Labels.Add("11月");
            xAxis.Labels.Add("12月");
            plotModel.Axes.Add(xAxis);

            // ラインY軸
            LinearAxis yAxis = new LinearAxis();
            yAxis.Position = AxisPosition.Left;
            yAxis.Key = "yAxis";
            yAxis.Minimum = 0;
            plotModel.Axes.Add(yAxis);

            // 2021年 売上
            BarSeries barSeries1 = new BarSeries();
            barSeries1.Title = "2021年";
            barSeries1.XAxisKey = "yAxis";
            barSeries1.YAxisKey = "xAxis";
            barSeries1.FillColor = OxyColors.Blue;
            barSeries1.StrokeThickness = 1;
            barSeries1.StrokeColor = OxyColors.Black;
            barSeries1.BarWidth = 40;
            barSeries1.IsStacked = true;
            barSeries1.OverlapsStack = true;
            barSeries1.StackGroup = "1";

            barSeries1.Items.Add(new BarItem() { Value = 53 });
            barSeries1.Items.Add(new BarItem() { Value = 51 });
            barSeries1.Items.Add(new BarItem() { Value = 48 });
            barSeries1.Items.Add(new BarItem() { Value = 50 });
            barSeries1.Items.Add(new BarItem() { Value = 39 });
            barSeries1.Items.Add(new BarItem() { Value = 34 });
            barSeries1.Items.Add(new BarItem() { Value = 45 });
            barSeries1.Items.Add(new BarItem() { Value = 65 });
            barSeries1.Items.Add(new BarItem() { Value = 64 });
            barSeries1.Items.Add(new BarItem() { Value = 63 });
            barSeries1.Items.Add(new BarItem() { Value = 70 });
            barSeries1.Items.Add(new BarItem() { Value = 67 });
            plotModel.Series.Add(barSeries1);

            // 2022年 売上
            BarSeries barSeries2 = new BarSeries();
            barSeries2.Title = "2022年";
            barSeries2.XAxisKey = "yAxis";
            barSeries2.YAxisKey = "xAxis";
            barSeries2.FillColor = OxyColors.Green;
            barSeries2.StrokeThickness = 1;
            barSeries2.StrokeColor = OxyColors.Black;
            barSeries2.BarWidth = 40;
            barSeries2.IsStacked = true;
            barSeries2.OverlapsStack = true;
            barSeries2.StackGroup = "1";

            barSeries2.Items.Add(new BarItem() { Value = 24 });
            barSeries2.Items.Add(new BarItem() { Value = 22 });
            barSeries2.Items.Add(new BarItem() { Value = 20 });
            barSeries2.Items.Add(new BarItem() { Value = 19 });
            barSeries2.Items.Add(new BarItem() { Value = 32 });
            barSeries2.Items.Add(new BarItem() { Value = 15 });
            barSeries2.Items.Add(new BarItem() { Value = 29 });
            barSeries2.Items.Add(new BarItem() { Value = 26 });
            barSeries2.Items.Add(new BarItem() { Value = 29 });
            barSeries2.Items.Add(new BarItem() { Value = 30 });
            barSeries2.Items.Add(new BarItem() { Value = 21 });
            barSeries2.Items.Add(new BarItem() { Value = 30 });
            plotModel.Series.Add(barSeries2);

            // 凡例
            Legend legend = new Legend();
            legend.LegendSymbolLength = 30;
            legend.LegendPosition = LegendPosition.TopLeft;
            plotModel.Legends.Add(legend);

            return plotModel;
        }
    }
}
