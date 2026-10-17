// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class InnerServiceServiceReportConfigurationFactory(Action<Humidifier.ResilienceHubV2.ServiceTypes.ServiceReportConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHubV2.ServiceTypes.ServiceReportConfiguration>
{

    protected override Humidifier.ResilienceHubV2.ServiceTypes.ServiceReportConfiguration Create()
    {
        var serviceReportConfigurationResult = CreateServiceReportConfiguration();
        factoryAction?.Invoke(serviceReportConfigurationResult);

        return serviceReportConfigurationResult;
    }

    private Humidifier.ResilienceHubV2.ServiceTypes.ServiceReportConfiguration CreateServiceReportConfiguration()
    {
        var serviceReportConfigurationResult = new Humidifier.ResilienceHubV2.ServiceTypes.ServiceReportConfiguration();

        return serviceReportConfigurationResult;
    }

} // End Of Class

public static class InnerServiceServiceReportConfigurationFactoryExtensions
{
}
