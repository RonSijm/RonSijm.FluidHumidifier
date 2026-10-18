// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileSalesforceConnectorProfilePropertiesFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.SalesforceConnectorProfileProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.SalesforceConnectorProfileProperties>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.SalesforceConnectorProfileProperties Create()
    {
        var salesforceConnectorProfilePropertiesResult = CreateSalesforceConnectorProfileProperties();
        factoryAction?.Invoke(salesforceConnectorProfilePropertiesResult);

        return salesforceConnectorProfilePropertiesResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.SalesforceConnectorProfileProperties CreateSalesforceConnectorProfileProperties()
    {
        var salesforceConnectorProfilePropertiesResult = new Humidifier.AppFlow.ConnectorProfileTypes.SalesforceConnectorProfileProperties();

        return salesforceConnectorProfilePropertiesResult;
    }

} // End Of Class

public static class InnerConnectorProfileSalesforceConnectorProfilePropertiesFactoryExtensions
{
}
