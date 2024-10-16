// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerDomainConfigurationAuthorizerConfigFactory(Action<Humidifier.IoT.DomainConfigurationTypes.AuthorizerConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.DomainConfigurationTypes.AuthorizerConfig>
{

    protected override Humidifier.IoT.DomainConfigurationTypes.AuthorizerConfig Create()
    {
        var authorizerConfigResult = CreateAuthorizerConfig();
        factoryAction?.Invoke(authorizerConfigResult);

        return authorizerConfigResult;
    }

    private Humidifier.IoT.DomainConfigurationTypes.AuthorizerConfig CreateAuthorizerConfig()
    {
        var authorizerConfigResult = new Humidifier.IoT.DomainConfigurationTypes.AuthorizerConfig();

        return authorizerConfigResult;
    }

} // End Of Class

public static class InnerDomainConfigurationAuthorizerConfigFactoryExtensions
{
}
