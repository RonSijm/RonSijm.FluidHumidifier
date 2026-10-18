// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardVisualAxisSortOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.VisualAxisSortOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.VisualAxisSortOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.VisualAxisSortOption Create()
    {
        var visualAxisSortOptionResult = CreateVisualAxisSortOption();
        factoryAction?.Invoke(visualAxisSortOptionResult);

        return visualAxisSortOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.VisualAxisSortOption CreateVisualAxisSortOption()
    {
        var visualAxisSortOptionResult = new Humidifier.QuickSight.DashboardTypes.VisualAxisSortOption();

        return visualAxisSortOptionResult;
    }

} // End Of Class

public static class InnerDashboardVisualAxisSortOptionFactoryExtensions
{
}
