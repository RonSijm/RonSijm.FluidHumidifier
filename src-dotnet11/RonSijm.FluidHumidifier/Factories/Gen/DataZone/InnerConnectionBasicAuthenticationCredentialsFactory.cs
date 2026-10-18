// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionBasicAuthenticationCredentialsFactory(Action<Humidifier.DataZone.ConnectionTypes.BasicAuthenticationCredentials> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.BasicAuthenticationCredentials>
{

    protected override Humidifier.DataZone.ConnectionTypes.BasicAuthenticationCredentials Create()
    {
        var basicAuthenticationCredentialsResult = CreateBasicAuthenticationCredentials();
        factoryAction?.Invoke(basicAuthenticationCredentialsResult);

        return basicAuthenticationCredentialsResult;
    }

    private Humidifier.DataZone.ConnectionTypes.BasicAuthenticationCredentials CreateBasicAuthenticationCredentials()
    {
        var basicAuthenticationCredentialsResult = new Humidifier.DataZone.ConnectionTypes.BasicAuthenticationCredentials();

        return basicAuthenticationCredentialsResult;
    }

} // End Of Class

public static class InnerConnectionBasicAuthenticationCredentialsFactoryExtensions
{
}
