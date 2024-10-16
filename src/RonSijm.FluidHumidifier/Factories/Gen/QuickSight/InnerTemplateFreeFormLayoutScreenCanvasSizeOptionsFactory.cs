// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions>
{

    protected override Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions Create()
    {
        var freeFormLayoutScreenCanvasSizeOptionsResult = CreateFreeFormLayoutScreenCanvasSizeOptions();
        factoryAction?.Invoke(freeFormLayoutScreenCanvasSizeOptionsResult);

        return freeFormLayoutScreenCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions CreateFreeFormLayoutScreenCanvasSizeOptions()
    {
        var freeFormLayoutScreenCanvasSizeOptionsResult = new Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions();

        return freeFormLayoutScreenCanvasSizeOptionsResult;
    }

} // End Of Class

public static class InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactoryExtensions
{
}
