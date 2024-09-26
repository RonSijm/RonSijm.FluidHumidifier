// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class IdentityPoolPrincipalTagFactory(string resourceName = null, Action<Humidifier.Cognito.IdentityPoolPrincipalTag> factoryAction = null) : ResourceFactory<Humidifier.Cognito.IdentityPoolPrincipalTag>(resourceName)
{

    protected override Humidifier.Cognito.IdentityPoolPrincipalTag Create()
    {
        var identityPoolPrincipalTagResult = CreateIdentityPoolPrincipalTag();
        factoryAction?.Invoke(identityPoolPrincipalTagResult);

        return identityPoolPrincipalTagResult;
    }

    private Humidifier.Cognito.IdentityPoolPrincipalTag CreateIdentityPoolPrincipalTag()
    {
        var identityPoolPrincipalTagResult = new Humidifier.Cognito.IdentityPoolPrincipalTag
        {
            GivenName = InputResourceName,
        };

        return identityPoolPrincipalTagResult;
    }

} // End Of Class

public static class IdentityPoolPrincipalTagFactoryExtensions
{
}
