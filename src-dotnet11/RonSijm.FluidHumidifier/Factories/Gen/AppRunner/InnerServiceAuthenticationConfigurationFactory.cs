// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerServiceAuthenticationConfigurationFactory(Action<Humidifier.AppRunner.ServiceTypes.AuthenticationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ServiceTypes.AuthenticationConfiguration>
{

    protected override Humidifier.AppRunner.ServiceTypes.AuthenticationConfiguration Create()
    {
        var authenticationConfigurationResult = CreateAuthenticationConfiguration();
        factoryAction?.Invoke(authenticationConfigurationResult);

        return authenticationConfigurationResult;
    }

    private Humidifier.AppRunner.ServiceTypes.AuthenticationConfiguration CreateAuthenticationConfiguration()
    {
        var authenticationConfigurationResult = new Humidifier.AppRunner.ServiceTypes.AuthenticationConfiguration();

        return authenticationConfigurationResult;
    }

} // End Of Class

public static class InnerServiceAuthenticationConfigurationFactoryExtensions
{
}
