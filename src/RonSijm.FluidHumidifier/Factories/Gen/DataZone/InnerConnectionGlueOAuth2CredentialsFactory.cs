// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionGlueOAuth2CredentialsFactory(Action<Humidifier.DataZone.ConnectionTypes.GlueOAuth2Credentials> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.GlueOAuth2Credentials>
{

    protected override Humidifier.DataZone.ConnectionTypes.GlueOAuth2Credentials Create()
    {
        var glueOAuth2CredentialsResult = CreateGlueOAuth2Credentials();
        factoryAction?.Invoke(glueOAuth2CredentialsResult);

        return glueOAuth2CredentialsResult;
    }

    private Humidifier.DataZone.ConnectionTypes.GlueOAuth2Credentials CreateGlueOAuth2Credentials()
    {
        var glueOAuth2CredentialsResult = new Humidifier.DataZone.ConnectionTypes.GlueOAuth2Credentials();

        return glueOAuth2CredentialsResult;
    }

} // End Of Class

public static class InnerConnectionGlueOAuth2CredentialsFactoryExtensions
{
}
