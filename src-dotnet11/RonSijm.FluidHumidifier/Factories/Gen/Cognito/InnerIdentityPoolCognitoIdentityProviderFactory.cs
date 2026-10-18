// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerIdentityPoolCognitoIdentityProviderFactory(Action<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider>
{

    protected override Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider Create()
    {
        var cognitoIdentityProviderResult = CreateCognitoIdentityProvider();
        factoryAction?.Invoke(cognitoIdentityProviderResult);

        return cognitoIdentityProviderResult;
    }

    private Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider CreateCognitoIdentityProvider()
    {
        var cognitoIdentityProviderResult = new Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider();

        return cognitoIdentityProviderResult;
    }

} // End Of Class

public static class InnerIdentityPoolCognitoIdentityProviderFactoryExtensions
{
}
