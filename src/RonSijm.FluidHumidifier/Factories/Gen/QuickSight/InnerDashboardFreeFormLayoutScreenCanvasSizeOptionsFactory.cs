// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions>
{

    protected override Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions Create()
    {
        var freeFormLayoutScreenCanvasSizeOptionsResult = CreateFreeFormLayoutScreenCanvasSizeOptions();
        factoryAction?.Invoke(freeFormLayoutScreenCanvasSizeOptionsResult);

        return freeFormLayoutScreenCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions CreateFreeFormLayoutScreenCanvasSizeOptions()
    {
        var freeFormLayoutScreenCanvasSizeOptionsResult = new Humidifier.QuickSight.DashboardTypes.FreeFormLayoutScreenCanvasSizeOptions();

        return freeFormLayoutScreenCanvasSizeOptionsResult;
    }

} // End Of Class

public static class InnerDashboardFreeFormLayoutScreenCanvasSizeOptionsFactoryExtensions
{
}
