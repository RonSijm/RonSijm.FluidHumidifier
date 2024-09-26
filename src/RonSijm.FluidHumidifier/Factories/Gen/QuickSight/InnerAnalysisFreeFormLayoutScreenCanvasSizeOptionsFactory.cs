// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions>
{

    protected override Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions Create()
    {
        var freeFormLayoutScreenCanvasSizeOptionsResult = CreateFreeFormLayoutScreenCanvasSizeOptions();
        factoryAction?.Invoke(freeFormLayoutScreenCanvasSizeOptionsResult);

        return freeFormLayoutScreenCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions CreateFreeFormLayoutScreenCanvasSizeOptions()
    {
        var freeFormLayoutScreenCanvasSizeOptionsResult = new Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions();

        return freeFormLayoutScreenCanvasSizeOptionsResult;
    }

} // End Of Class

public static class InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactoryExtensions
{
}
