// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerIntegrationZendeskSourcePropertiesFactory(Action<Humidifier.CustomerProfiles.IntegrationTypes.ZendeskSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.IntegrationTypes.ZendeskSourceProperties>
{

    protected override Humidifier.CustomerProfiles.IntegrationTypes.ZendeskSourceProperties Create()
    {
        var zendeskSourcePropertiesResult = CreateZendeskSourceProperties();
        factoryAction?.Invoke(zendeskSourcePropertiesResult);

        return zendeskSourcePropertiesResult;
    }

    private Humidifier.CustomerProfiles.IntegrationTypes.ZendeskSourceProperties CreateZendeskSourceProperties()
    {
        var zendeskSourcePropertiesResult = new Humidifier.CustomerProfiles.IntegrationTypes.ZendeskSourceProperties();

        return zendeskSourcePropertiesResult;
    }

} // End Of Class

public static class InnerIntegrationZendeskSourcePropertiesFactoryExtensions
{
}
