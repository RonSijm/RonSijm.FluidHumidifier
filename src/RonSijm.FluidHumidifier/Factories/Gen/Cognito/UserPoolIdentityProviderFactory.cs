// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class UserPoolIdentityProviderFactory(string resourceName = null, Action<Humidifier.Cognito.UserPoolIdentityProvider> factoryAction = null) : ResourceFactory<Humidifier.Cognito.UserPoolIdentityProvider>(resourceName)
{

    protected override Humidifier.Cognito.UserPoolIdentityProvider Create()
    {
        var userPoolIdentityProviderResult = CreateUserPoolIdentityProvider();
        factoryAction?.Invoke(userPoolIdentityProviderResult);

        return userPoolIdentityProviderResult;
    }

    private Humidifier.Cognito.UserPoolIdentityProvider CreateUserPoolIdentityProvider()
    {
        var userPoolIdentityProviderResult = new Humidifier.Cognito.UserPoolIdentityProvider
        {
            GivenName = InputResourceName,
        };

        return userPoolIdentityProviderResult;
    }

} // End Of Class

public static class UserPoolIdentityProviderFactoryExtensions
{
}
