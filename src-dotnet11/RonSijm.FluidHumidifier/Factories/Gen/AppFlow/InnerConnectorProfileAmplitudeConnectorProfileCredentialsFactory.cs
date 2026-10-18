// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileAmplitudeConnectorProfileCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.AmplitudeConnectorProfileCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.AmplitudeConnectorProfileCredentials>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.AmplitudeConnectorProfileCredentials Create()
    {
        var amplitudeConnectorProfileCredentialsResult = CreateAmplitudeConnectorProfileCredentials();
        factoryAction?.Invoke(amplitudeConnectorProfileCredentialsResult);

        return amplitudeConnectorProfileCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.AmplitudeConnectorProfileCredentials CreateAmplitudeConnectorProfileCredentials()
    {
        var amplitudeConnectorProfileCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.AmplitudeConnectorProfileCredentials();

        return amplitudeConnectorProfileCredentialsResult;
    }

} // End Of Class

public static class InnerConnectorProfileAmplitudeConnectorProfileCredentialsFactoryExtensions
{
}
