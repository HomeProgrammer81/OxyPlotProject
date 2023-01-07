using OxyPlot;

namespace OxyPlotProject.OxyPlotPlotModel
{
    /// <summary>
    /// PlotModelアブストファクトリー
    /// </summary>
    internal abstract class AbstPlotModelFactory
    {
        public abstract PlotModel Create();
    }
}
