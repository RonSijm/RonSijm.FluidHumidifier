// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerIntegrationServiceNowSourcePropertiesFactory(Action<Humidifier.CustomerProfiles.IntegrationTypes.ServiceNowSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.IntegrationTypes.ServiceNowSourceProperties>
{

    protected override Humidifier.CustomerProfiles.IntegrationTypes.ServiceNowSourceProperties Create()
    {
        var serviceNowSourcePropertiesResult = CreateServiceNowSourceProperties();
        factoryAction?.Invoke(serviceNowSourcePropertiesResult);

        return serviceNowSourcePropertiesResult;
    }

    private Humidifier.CustomerProfiles.IntegrationTypes.ServiceNowSourceProperties CreateServiceNowSourceProperties()
    {
        var serviceNowSourcePropertiesResult = new Humidifier.CustomerProfiles.IntegrationTypes.ServiceNowSourceProperties();

        return serviceNowSourcePropertiesResult;
    }

} // End Of Class

public static class InnerIntegrationServiceNowSourcePropertiesFactoryExtensions
{
}
