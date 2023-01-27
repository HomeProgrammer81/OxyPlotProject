using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Series;
using System;
using System.Collections.Generic;

namespace OxyPlotProject.OxyPlotPlotModel
{
    /// <summary>
    /// 円グラフPlotModelファクトリー
    /// </summary>
    internal class PieSeriesPlotModelFactory : AbstPlotModelFactory
    {
        private List<Tuple<string, double>> pieDataList = new List<Tuple<string, double>>()
        {
            new Tuple<string, double>( "商品A", 25394),
            new Tuple<string, double>( "商品B", 20343),
            new Tuple<string, double>( "商品C", 15400),
            new Tuple<string, double>( "商品D", 10200),
            new Tuple<string, double>( "その他", 9200),
        };

        public override PlotModel Create()
        {
            // モデル
            PlotModel plotModel = new PlotModel();
            plotModel.Title = "商品-売上割合 円グラフ";
            plotModel.TitlePadding= 20;                     // タイトルのパディング

            // パイシリーズ
            PieSeries pieSeries = new PieSeries();

            pieSeries.InsideLabelColor = OxyColors.White;   // 内部ラベルの色
            pieSeries.InsideLabelPosition = 0.7;            // 内部ラベル位置

            pieSeries.FontSize = 18;                        // フォントサイズ

            pieSeries.Stroke = OxyColors.WhiteSmoke;        // ボーダーの色
            pieSeries.StrokeThickness = 3;                  // ボーダーの幅
            
            pieSeries.TickDistance = 4;                     // 円の端と、割合の線の距離

            pieSeries.StartAngle = -90;                     // データの開始角度

            // データ設定
            foreach( Tuple<string, double> tuple in pieDataList )
            {
                PieSlice pieSlice = new PieSlice(tuple.Item1, tuple.Item2);
                pieSeries.Slices.Add(pieSlice);
            }

            plotModel.Series.Add(pieSeries);

            return plotModel;
        }
    }
}
