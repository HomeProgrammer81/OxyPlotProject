using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;

namespace OxyPlotProject.OxyPlotPlotModel
{
    /// <summary>
    /// 円グラフPlotModelファクトリー
    /// </summary>
    internal class PieSeriesCutPlotModelFactory : AbstPlotModelFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Item1 : ラベル名
        /// Item2 : 商品売り上げ値
        /// Item3 : 切り抜きフラグ
        /// Item4 : 背景色
        /// </remarks>
        private List<Tuple<string, double, bool, OxyColor>> PieSliceList = new List<Tuple<string, double, bool, OxyColor>>()
        {
            new Tuple<string, double,bool,OxyColor>( "商品A", 25394, true, OxyColors.Red),
            new Tuple<string, double,bool,OxyColor>( "商品B", 20343, false, OxyColors.DarkGray),
            new Tuple<string, double,bool,OxyColor>( "商品C", 15400, false, OxyColors.DarkGray),
            new Tuple<string, double,bool,OxyColor>( "商品D", 10200, false, OxyColors.DarkGray),
            new Tuple<string, double,bool,OxyColor>( "その他", 9200, false, OxyColors.DarkGray),
        };

        public override PlotModel Create()
        {
            // モデル
            PlotModel plotModel = new PlotModel();
            plotModel.Title = "商品-売上割合 円グラフ";
            plotModel.TitlePadding = 20;                     // タイトルのパディング

            // パイシリーズ
            PieSeries pieSeries = new PieSeries();

            pieSeries.InsideLabelColor = OxyColors.White;   // 内部ラベルの色
            pieSeries.InsideLabelPosition = 0.7;            // 内部ラベル位置

            pieSeries.FontSize = 18;                        // フォントサイズ

            pieSeries.Stroke = OxyColors.WhiteSmoke;        // ボーダーの色
            pieSeries.StrokeThickness = 3;                  // ボーダーの幅

            pieSeries.TickDistance = 4;                     // 円の端と、割合の線の距離

            pieSeries.StartAngle = -90;                     // データの開始角度
            pieSeries.ExplodedDistance = 0.1;               // 円の中心からの距離

            // データ設定
            foreach (Tuple<string, double, bool, OxyColor> tuple in PieSliceList)
            {
                PieSlice pieSlice = new PieSlice(tuple.Item1, tuple.Item2);
                pieSlice.IsExploded = tuple.Item3;          // 強調するときはtrue
                pieSlice.Fill = tuple.Item4;                // 強調するときは色を変える

                pieSeries.Slices.Add(pieSlice);
            }

            plotModel.Series.Add(pieSeries);

            return plotModel;
        }
    }
}
