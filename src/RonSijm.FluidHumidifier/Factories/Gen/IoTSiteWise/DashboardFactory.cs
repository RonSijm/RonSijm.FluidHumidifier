// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class DashboardFactory(string resourceName = null, Action<Humidifier.IoTSiteWise.Dashboard> factoryAction = null) : ResourceFactory<Humidifier.IoTSiteWise.Dashboard>(resourceName)
{

    protected override Humidifier.IoTSiteWise.Dashboard Create()
    {
        var dashboardResult = CreateDashboard();
        factoryAction?.Invoke(dashboardResult);

        return dashboardResult;
    }

    private Humidifier.IoTSiteWise.Dashboard CreateDashboard()
    {
        var dashboardResult = new Humidifier.IoTSiteWise.Dashboard
        {
            GivenName = InputResourceName,
        };

        return dashboardResult;
    }

} // End Of Class

public static class DashboardFactoryExtensions
{
}
