// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileVeevaConnectorProfileCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.VeevaConnectorProfileCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.VeevaConnectorProfileCredentials>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.VeevaConnectorProfileCredentials Create()
    {
        var veevaConnectorProfileCredentialsResult = CreateVeevaConnectorProfileCredentials();
        factoryAction?.Invoke(veevaConnectorProfileCredentialsResult);

        return veevaConnectorProfileCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.VeevaConnectorProfileCredentials CreateVeevaConnectorProfileCredentials()
    {
        var veevaConnectorProfileCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.VeevaConnectorProfileCredentials();

        return veevaConnectorProfileCredentialsResult;
    }

} // End Of Class

public static class InnerConnectorProfileVeevaConnectorProfileCredentialsFactoryExtensions
{
}
