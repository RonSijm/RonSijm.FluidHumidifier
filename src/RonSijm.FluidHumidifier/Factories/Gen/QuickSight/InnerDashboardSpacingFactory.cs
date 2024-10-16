// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardSpacingFactory(Action<Humidifier.QuickSight.DashboardTypes.Spacing> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.Spacing>
{

    protected override Humidifier.QuickSight.DashboardTypes.Spacing Create()
    {
        var spacingResult = CreateSpacing();
        factoryAction?.Invoke(spacingResult);

        return spacingResult;
    }

    private Humidifier.QuickSight.DashboardTypes.Spacing CreateSpacing()
    {
        var spacingResult = new Humidifier.QuickSight.DashboardTypes.Spacing();

        return spacingResult;
    }

} // End Of Class

public static class InnerDashboardSpacingFactoryExtensions
{
}
