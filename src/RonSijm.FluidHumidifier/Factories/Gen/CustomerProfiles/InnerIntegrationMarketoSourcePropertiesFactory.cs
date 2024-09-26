// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerIntegrationMarketoSourcePropertiesFactory(Action<Humidifier.CustomerProfiles.IntegrationTypes.MarketoSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.IntegrationTypes.MarketoSourceProperties>
{

    protected override Humidifier.CustomerProfiles.IntegrationTypes.MarketoSourceProperties Create()
    {
        var marketoSourcePropertiesResult = CreateMarketoSourceProperties();
        factoryAction?.Invoke(marketoSourcePropertiesResult);

        return marketoSourcePropertiesResult;
    }

    private Humidifier.CustomerProfiles.IntegrationTypes.MarketoSourceProperties CreateMarketoSourceProperties()
    {
        var marketoSourcePropertiesResult = new Humidifier.CustomerProfiles.IntegrationTypes.MarketoSourceProperties();

        return marketoSourcePropertiesResult;
    }

} // End Of Class

public static class InnerIntegrationMarketoSourcePropertiesFactoryExtensions
{
}
