// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryCustomJWTAuthorizerConfigurationFactory(Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration>
{

    protected override Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration Create()
    {
        var customJWTAuthorizerConfigurationResult = CreateCustomJWTAuthorizerConfiguration();
        factoryAction?.Invoke(customJWTAuthorizerConfigurationResult);

        return customJWTAuthorizerConfigurationResult;
    }

    private Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration CreateCustomJWTAuthorizerConfiguration()
    {
        var customJWTAuthorizerConfigurationResult = new Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration();

        return customJWTAuthorizerConfigurationResult;
    }

} // End Of Class

public static class InnerRegistryCustomJWTAuthorizerConfigurationFactoryExtensions
{
}
