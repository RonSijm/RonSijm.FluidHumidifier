// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionOAuth2CredentialsFactory(Action<Humidifier.Glue.ConnectionTypes.OAuth2Credentials> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypes.OAuth2Credentials>
{

    protected override Humidifier.Glue.ConnectionTypes.OAuth2Credentials Create()
    {
        var oAuth2CredentialsResult = CreateOAuth2Credentials();
        factoryAction?.Invoke(oAuth2CredentialsResult);

        return oAuth2CredentialsResult;
    }

    private Humidifier.Glue.ConnectionTypes.OAuth2Credentials CreateOAuth2Credentials()
    {
        var oAuth2CredentialsResult = new Humidifier.Glue.ConnectionTypes.OAuth2Credentials();

        return oAuth2CredentialsResult;
    }

} // End Of Class

public static class InnerConnectionOAuth2CredentialsFactoryExtensions
{
}
