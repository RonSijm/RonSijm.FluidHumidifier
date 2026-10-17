// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53GlobalResolver;

public class AccessTokenFactory(string resourceName = null, Action<Humidifier.Route53GlobalResolver.AccessToken> factoryAction = null) : ResourceFactory<Humidifier.Route53GlobalResolver.AccessToken>(resourceName)
{

    protected override Humidifier.Route53GlobalResolver.AccessToken Create()
    {
        var accessTokenResult = CreateAccessToken();
        factoryAction?.Invoke(accessTokenResult);

        return accessTokenResult;
    }

    private Humidifier.Route53GlobalResolver.AccessToken CreateAccessToken()
    {
        var accessTokenResult = new Humidifier.Route53GlobalResolver.AccessToken
        {
            GivenName = InputResourceName,
        };

        return accessTokenResult;
    }

} // End Of Class

public static class AccessTokenFactoryExtensions
{
}
