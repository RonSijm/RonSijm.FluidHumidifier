// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetDashboardOptionsFactory(Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetTypes.DashboardOptions>
{

    protected override Humidifier.SES.ConfigurationSetTypes.DashboardOptions Create()
    {
        var dashboardOptionsResult = CreateDashboardOptions();
        factoryAction?.Invoke(dashboardOptionsResult);

        return dashboardOptionsResult;
    }

    private Humidifier.SES.ConfigurationSetTypes.DashboardOptions CreateDashboardOptions()
    {
        var dashboardOptionsResult = new Humidifier.SES.ConfigurationSetTypes.DashboardOptions();

        return dashboardOptionsResult;
    }

} // End Of Class

public static class InnerConfigurationSetDashboardOptionsFactoryExtensions
{
}
