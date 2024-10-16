// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolUsernameConfigurationFactory(Action<Humidifier.Cognito.UserPoolTypes.UsernameConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.UsernameConfiguration>
{

    protected override Humidifier.Cognito.UserPoolTypes.UsernameConfiguration Create()
    {
        var usernameConfigurationResult = CreateUsernameConfiguration();
        factoryAction?.Invoke(usernameConfigurationResult);

        return usernameConfigurationResult;
    }

    private Humidifier.Cognito.UserPoolTypes.UsernameConfiguration CreateUsernameConfiguration()
    {
        var usernameConfigurationResult = new Humidifier.Cognito.UserPoolTypes.UsernameConfiguration();

        return usernameConfigurationResult;
    }

} // End Of Class

public static class InnerUserPoolUsernameConfigurationFactoryExtensions
{
}
