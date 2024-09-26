// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class DashboardFactory(string resourceName = null, Action<Humidifier.CloudWatch.Dashboard> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.Dashboard>(resourceName)
{

    protected override Humidifier.CloudWatch.Dashboard Create()
    {
        var dashboardResult = CreateDashboard();
        factoryAction?.Invoke(dashboardResult);

        return dashboardResult;
    }

    private Humidifier.CloudWatch.Dashboard CreateDashboard()
    {
        var dashboardResult = new Humidifier.CloudWatch.Dashboard
        {
            GivenName = InputResourceName,
        };

        return dashboardResult;
    }

} // End Of Class

public static class DashboardFactoryExtensions
{
}
