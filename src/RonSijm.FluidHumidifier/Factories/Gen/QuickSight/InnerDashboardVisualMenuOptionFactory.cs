// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardVisualMenuOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.VisualMenuOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.VisualMenuOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.VisualMenuOption Create()
    {
        var visualMenuOptionResult = CreateVisualMenuOption();
        factoryAction?.Invoke(visualMenuOptionResult);

        return visualMenuOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.VisualMenuOption CreateVisualMenuOption()
    {
        var visualMenuOptionResult = new Humidifier.QuickSight.DashboardTypes.VisualMenuOption();

        return visualMenuOptionResult;
    }

} // End Of Class

public static class InnerDashboardVisualMenuOptionFactoryExtensions
{
}
