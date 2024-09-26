// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileDatadogConnectorProfileCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.DatadogConnectorProfileCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.DatadogConnectorProfileCredentials>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.DatadogConnectorProfileCredentials Create()
    {
        var datadogConnectorProfileCredentialsResult = CreateDatadogConnectorProfileCredentials();
        factoryAction?.Invoke(datadogConnectorProfileCredentialsResult);

        return datadogConnectorProfileCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.DatadogConnectorProfileCredentials CreateDatadogConnectorProfileCredentials()
    {
        var datadogConnectorProfileCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.DatadogConnectorProfileCredentials();

        return datadogConnectorProfileCredentialsResult;
    }

} // End Of Class

public static class InnerConnectorProfileDatadogConnectorProfileCredentialsFactoryExtensions
{
}
