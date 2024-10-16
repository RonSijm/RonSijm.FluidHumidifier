// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions>
{

    protected override Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions Create()
    {
        var gridLayoutScreenCanvasSizeOptionsResult = CreateGridLayoutScreenCanvasSizeOptions();
        factoryAction?.Invoke(gridLayoutScreenCanvasSizeOptionsResult);

        return gridLayoutScreenCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions CreateGridLayoutScreenCanvasSizeOptions()
    {
        var gridLayoutScreenCanvasSizeOptionsResult = new Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions();

        return gridLayoutScreenCanvasSizeOptionsResult;
    }

} // End Of Class

public static class InnerTemplateGridLayoutScreenCanvasSizeOptionsFactoryExtensions
{
}
