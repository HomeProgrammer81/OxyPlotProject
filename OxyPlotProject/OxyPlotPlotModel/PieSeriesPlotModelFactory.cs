using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Series;
using System;
using System.Collections.Generic;

namespace OxyPlotProject.OxyPlotPlotModel
{
    /// <summary>
    /// 円グラフ 二重 PlotModelファクトリー
    /// </summary>
    internal class PieSeriesPlotModelFactory : AbstPlotModelFactory
    {
        private List<Tuple<string, double, OxyColor>> pieDataList = new List<Tuple<string, double, OxyColor>>()
        {
            new Tuple<string, double, OxyColor>( "商品A", 25394, OxyColors.DarkBlue),
            new Tuple<string, double, OxyColor>( "商品B", 20343, OxyColors.YellowGreen),
            new Tuple<string, double, OxyColor>( "商品C", 15400, OxyColors.OrangeRed),
            new Tuple<string, double, OxyColor>( "商品D", 10200, OxyColors.ForestGreen),
            new Tuple<string, double, OxyColor>( "その他", 9200, OxyColors.Gray),
        };

        private List<Tuple<string, double, OxyColor>> subPieDataList = new List<Tuple<string, double, OxyColor>>()
        {
            new Tuple<string, double, OxyColor>( "A-1", 10000, OxyColors.DarkBlue),
            new Tuple<string, double, OxyColor>( "A-2", 10000, OxyColors.DarkBlue),
            new Tuple<string, double, OxyColor>( "A-3", 5394, OxyColors.DarkBlue),
            new Tuple<string, double, OxyColor>( "B-1", 10000, OxyColors.YellowGreen),
            new Tuple<string, double, OxyColor>( "B-2", 10343, OxyColors.YellowGreen),
            new Tuple<string, double, OxyColor>( "C-1", 10000, OxyColors.OrangeRed),
            new Tuple<string, double, OxyColor>( "C-2", 5400, OxyColors.OrangeRed),
            new Tuple<string, double, OxyColor>( "D-1", 10200,  OxyColors.ForestGreen),
            new Tuple<string, double, OxyColor>( "その他", 9200, OxyColors.Gray),
        };

        public override PlotModel Create()
        {
            // モデル
            PlotModel plotModel = new PlotModel();
            plotModel.Title = "商品-売上割合 円グラフ";
            plotModel.TitlePadding= 20;                     // タイトルのパディング

            // 内側の円
            PieSeries pieSeries = new PieSeries();

            pieSeries.InsideLabelColor = OxyColors.White;   // 内部ラベルの色
            pieSeries.InsideLabelPosition = 0.7;            // 内部ラベル位置

            pieSeries.Diameter = 0.5;                       // 半径

            pieSeries.Stroke = OxyColors.WhiteSmoke;        // ボーダーの色
            pieSeries.StrokeThickness = 3;                  // ボーダーの幅
            
            pieSeries.StartAngle = -90;                     // データの開始角度

            // 円の外側に表示されるラベルは表示しない
            pieSeries.TickDistance = 0;
            pieSeries.TickLabelDistance = 0;
            pieSeries.TickRadialLength= 0;
            pieSeries.TickHorizontalLength = 0;
            pieSeries.OutsideLabelFormat = "";

            // データ設定
            foreach( Tuple<string, double, OxyColor> tuple in pieDataList )
            {
                PieSlice pieSlice = new PieSlice(tuple.Item1, tuple.Item2);
                pieSlice.Fill = tuple.Item3;
                pieSeries.Slices.Add(pieSlice);
            }

            plotModel.Series.Add(pieSeries);


            // 外側の円
            PieSeries subPieSeries = new PieSeries();

            subPieSeries.InsideLabelColor = OxyColors.White;   // 内部ラベルの色
            subPieSeries.InsideLabelPosition = 0.7;            // 内部ラベル位置

            subPieSeries.InnerDiameter = 0.5;                  // 内側の円の半径と一致させる

            subPieSeries.StartAngle = -90;                     // データの開始角度

            // 円の外側に表示されるラベルは表示しない
            subPieSeries.TickDistance = 0;
            subPieSeries.TickLabelDistance = 0;
            subPieSeries.TickRadialLength = 0;
            subPieSeries.TickHorizontalLength = 0;
            subPieSeries.OutsideLabelFormat = "";

            // データ設定
            foreach (Tuple<string, double, OxyColor> tuple in subPieDataList)
            {
                PieSlice pieSlice = new PieSlice(tuple.Item1, tuple.Item2);
                pieSlice.Fill = tuple.Item3;
                subPieSeries.Slices.Add(pieSlice);

            }

            plotModel.Series.Add(subPieSeries);

            return plotModel;
        }
    }
}
