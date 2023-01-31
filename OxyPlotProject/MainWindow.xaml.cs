using OxyPlot;
using OxyPlotProject.OxyPlotPlotModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace OxyPlotProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Id-名称一覧
        /// </summary>
        /// <remarks>
        /// リストボックスに設定
        /// Item1:Id
        /// Item2:名称
        /// </remarks>
        private readonly ObservableCollection<Tuple<string, string>> IdNames = new ObservableCollection<Tuple<string, string>>()
        {
            new Tuple<string, string>("pie", "円グラフ"),
            new Tuple<string, string>("piecut", "円グラフ-一部強調"),
            new Tuple<string, string>("piedouble", "円グラフ-二重"),
            new Tuple<string, string>("legendClickDisabled", "Legend(凡例)のクリック無効"),
            new Tuple<string, string>("yAxisLeftRight", "Y軸を左右に設定"),
            new Tuple<string, string>("xAxisCategoryBar", "X軸カテゴリーにバーを設定"),
            new Tuple<string, string>("lineBarSame", "ラインとバーを同グラフ"),
        };

        /// <summary>
        /// PlotModelファクトリーテーブル
        /// </summary>
        /// <remarks>
        /// Item1:Id
        /// Item2:PlotModelファクトリー
        /// </remarks>
        private readonly Dictionary<string, AbstPlotModelFactory> PlotModelFactoryTable = new Dictionary<string, AbstPlotModelFactory>()
        {
            {"pie", new PieSeriesPlotModelFactory() },
            {"piecut", new PieSeriesCutPlotModelFactory() },
            {"piedouble", new PieSeriesDoublePlotModelFactory() },
            {"legendClickDisabled", new LegendClickDisabledPlotModelFactory() },
            {"yAxisLeftRight", new YAxisLeftRightPlotModelFactory() },
            {"xAxisCategoryBar", new XAxisBarPlotModelFactory() },
            {"lineBarSame", new LineBarSamePlotModelFactory() },
        };

        public MainWindow()
        {
            InitializeComponent();

            ListBox_OxyPlotIdNames.ItemsSource = IdNames;
        }

        /// <summary>
        /// リストボックスの要素をクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_OxyPlotIdNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tuple<string, string>? idName = ListBox_OxyPlotIdNames.SelectedItem as Tuple<string, string>;
            if(idName==null)
            {
                return;
            }

            if(!PlotModelFactoryTable.ContainsKey(idName.Item1))
            {
                return;
            }

            AbstPlotModelFactory plotModelFactory = PlotModelFactoryTable[idName.Item1];
            PlotModel plotModel = plotModelFactory.Create();

            PlotView_Sample.Model = plotModel;
        }
    }
}
