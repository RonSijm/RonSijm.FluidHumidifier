// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileCustomAuthCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.CustomAuthCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.CustomAuthCredentials>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.CustomAuthCredentials Create()
    {
        var customAuthCredentialsResult = CreateCustomAuthCredentials();
        factoryAction?.Invoke(customAuthCredentialsResult);

        return customAuthCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.CustomAuthCredentials CreateCustomAuthCredentials()
    {
        var customAuthCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.CustomAuthCredentials();

        return customAuthCredentialsResult;
    }

} // End Of Class

public static class InnerConnectorProfileCustomAuthCredentialsFactoryExtensions
{
}
