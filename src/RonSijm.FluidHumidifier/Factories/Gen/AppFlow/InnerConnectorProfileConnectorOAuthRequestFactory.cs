// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileConnectorOAuthRequestFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest Create()
    {
        var connectorOAuthRequestResult = CreateConnectorOAuthRequest();
        factoryAction?.Invoke(connectorOAuthRequestResult);

        return connectorOAuthRequestResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest CreateConnectorOAuthRequest()
    {
        var connectorOAuthRequestResult = new Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest();

        return connectorOAuthRequestResult;
    }

} // End Of Class

public static class InnerConnectorProfileConnectorOAuthRequestFactoryExtensions
{
}
