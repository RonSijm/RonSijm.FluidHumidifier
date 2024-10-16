// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions>
{

    protected override Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions Create()
    {
        var gridLayoutScreenCanvasSizeOptionsResult = CreateGridLayoutScreenCanvasSizeOptions();
        factoryAction?.Invoke(gridLayoutScreenCanvasSizeOptionsResult);

        return gridLayoutScreenCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions CreateGridLayoutScreenCanvasSizeOptions()
    {
        var gridLayoutScreenCanvasSizeOptionsResult = new Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions();

        return gridLayoutScreenCanvasSizeOptionsResult;
    }

} // End Of Class

public static class InnerDashboardGridLayoutScreenCanvasSizeOptionsFactoryExtensions
{
}
