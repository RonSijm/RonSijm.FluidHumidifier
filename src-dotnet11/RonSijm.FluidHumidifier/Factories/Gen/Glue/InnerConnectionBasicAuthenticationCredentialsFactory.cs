// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionBasicAuthenticationCredentialsFactory(Action<Humidifier.Glue.ConnectionTypes.BasicAuthenticationCredentials> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypes.BasicAuthenticationCredentials>
{

    protected override Humidifier.Glue.ConnectionTypes.BasicAuthenticationCredentials Create()
    {
        var basicAuthenticationCredentialsResult = CreateBasicAuthenticationCredentials();
        factoryAction?.Invoke(basicAuthenticationCredentialsResult);

        return basicAuthenticationCredentialsResult;
    }

    private Humidifier.Glue.ConnectionTypes.BasicAuthenticationCredentials CreateBasicAuthenticationCredentials()
    {
        var basicAuthenticationCredentialsResult = new Humidifier.Glue.ConnectionTypes.BasicAuthenticationCredentials();

        return basicAuthenticationCredentialsResult;
    }

} // End Of Class

public static class InnerConnectionBasicAuthenticationCredentialsFactoryExtensions
{
}
