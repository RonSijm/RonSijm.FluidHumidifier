// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class OmniDashboardFactory(string resourceName = null, Action<Humidifier.CloudWatch.OmniDashboard> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.OmniDashboard>(resourceName)
{

    protected override Humidifier.CloudWatch.OmniDashboard Create()
    {
        var omniDashboardResult = CreateOmniDashboard();
        factoryAction?.Invoke(omniDashboardResult);

        return omniDashboardResult;
    }

    private Humidifier.CloudWatch.OmniDashboard CreateOmniDashboard()
    {
        var omniDashboardResult = new Humidifier.CloudWatch.OmniDashboard
        {
            GivenName = InputResourceName,
        };

        return omniDashboardResult;
    }

} // End Of Class

public static class OmniDashboardFactoryExtensions
{
}
