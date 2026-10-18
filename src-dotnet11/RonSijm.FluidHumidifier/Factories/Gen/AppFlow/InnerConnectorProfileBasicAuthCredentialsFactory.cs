// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileBasicAuthCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.BasicAuthCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.BasicAuthCredentials>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.BasicAuthCredentials Create()
    {
        var basicAuthCredentialsResult = CreateBasicAuthCredentials();
        factoryAction?.Invoke(basicAuthCredentialsResult);

        return basicAuthCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.BasicAuthCredentials CreateBasicAuthCredentials()
    {
        var basicAuthCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.BasicAuthCredentials();

        return basicAuthCredentialsResult;
    }

} // End Of Class

public static class InnerConnectorProfileBasicAuthCredentialsFactoryExtensions
{
}
