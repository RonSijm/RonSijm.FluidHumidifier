// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerIntegrationSalesforceSourcePropertiesFactory(Action<Humidifier.CustomerProfiles.IntegrationTypes.SalesforceSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.IntegrationTypes.SalesforceSourceProperties>
{

    protected override Humidifier.CustomerProfiles.IntegrationTypes.SalesforceSourceProperties Create()
    {
        var salesforceSourcePropertiesResult = CreateSalesforceSourceProperties();
        factoryAction?.Invoke(salesforceSourcePropertiesResult);

        return salesforceSourcePropertiesResult;
    }

    private Humidifier.CustomerProfiles.IntegrationTypes.SalesforceSourceProperties CreateSalesforceSourceProperties()
    {
        var salesforceSourcePropertiesResult = new Humidifier.CustomerProfiles.IntegrationTypes.SalesforceSourceProperties();

        return salesforceSourcePropertiesResult;
    }

} // End Of Class

public static class InnerIntegrationSalesforceSourcePropertiesFactoryExtensions
{
}
