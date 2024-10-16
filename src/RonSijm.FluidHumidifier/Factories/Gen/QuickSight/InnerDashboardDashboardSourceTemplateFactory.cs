// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardDashboardSourceTemplateFactory(Action<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate>
{

    protected override Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate Create()
    {
        var dashboardSourceTemplateResult = CreateDashboardSourceTemplate();
        factoryAction?.Invoke(dashboardSourceTemplateResult);

        return dashboardSourceTemplateResult;
    }

    private Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate CreateDashboardSourceTemplate()
    {
        var dashboardSourceTemplateResult = new Humidifier.QuickSight.DashboardTypes.DashboardSourceTemplate();

        return dashboardSourceTemplateResult;
    }

} // End Of Class

public static class InnerDashboardDashboardSourceTemplateFactoryExtensions
{
}
