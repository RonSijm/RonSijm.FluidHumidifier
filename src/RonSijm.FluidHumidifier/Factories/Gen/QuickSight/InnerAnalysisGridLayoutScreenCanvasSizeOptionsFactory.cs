// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions>
{

    protected override Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions Create()
    {
        var gridLayoutScreenCanvasSizeOptionsResult = CreateGridLayoutScreenCanvasSizeOptions();
        factoryAction?.Invoke(gridLayoutScreenCanvasSizeOptionsResult);

        return gridLayoutScreenCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions CreateGridLayoutScreenCanvasSizeOptions()
    {
        var gridLayoutScreenCanvasSizeOptionsResult = new Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions();

        return gridLayoutScreenCanvasSizeOptionsResult;
    }

} // End Of Class

public static class InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactoryExtensions
{
}
