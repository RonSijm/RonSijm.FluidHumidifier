// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryDiscoveryConfigurationFactory(Action<Humidifier.AgentRegistry.RegistryTypes.DiscoveryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryTypes.DiscoveryConfiguration>
{

    internal InnerRegistryAuthorizerConfigurationFactory AuthorizerConfigurationFactory { get; set; }

    protected override Humidifier.AgentRegistry.RegistryTypes.DiscoveryConfiguration Create()
    {
        var discoveryConfigurationResult = CreateDiscoveryConfiguration();
        factoryAction?.Invoke(discoveryConfigurationResult);

        return discoveryConfigurationResult;
    }

    private Humidifier.AgentRegistry.RegistryTypes.DiscoveryConfiguration CreateDiscoveryConfiguration()
    {
        var discoveryConfigurationResult = new Humidifier.AgentRegistry.RegistryTypes.DiscoveryConfiguration();

        return discoveryConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AgentRegistry.RegistryTypes.DiscoveryConfiguration result)
    {
        base.CreateChildren(result);

        result.AuthorizerConfiguration ??= AuthorizerConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRegistryDiscoveryConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRegistryDiscoveryConfigurationFactory, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration(this InnerRegistryDiscoveryConfigurationFactory parentFactory, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null)
    {
        parentFactory.AuthorizerConfigurationFactory = new InnerRegistryAuthorizerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizerConfigurationFactory);
    }

    public static CombinedResult<InnerRegistryDiscoveryConfigurationFactory, T1, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1>(this CombinedResult<InnerRegistryDiscoveryConfigurationFactory, T1> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryDiscoveryConfigurationFactory, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1>(this CombinedResult<T1, InnerRegistryDiscoveryConfigurationFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryDiscoveryConfigurationFactory, T1, T2, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2>(this CombinedResult<InnerRegistryDiscoveryConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryDiscoveryConfigurationFactory, T2, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2>(this CombinedResult<T1, InnerRegistryDiscoveryConfigurationFactory, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryDiscoveryConfigurationFactory, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRegistryDiscoveryConfigurationFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryDiscoveryConfigurationFactory, T1, T2, T3, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3>(this CombinedResult<InnerRegistryDiscoveryConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryDiscoveryConfigurationFactory, T2, T3, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRegistryDiscoveryConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryDiscoveryConfigurationFactory, T3, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRegistryDiscoveryConfigurationFactory, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryDiscoveryConfigurationFactory, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRegistryDiscoveryConfigurationFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryDiscoveryConfigurationFactory, T1, T2, T3, T4, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRegistryDiscoveryConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryDiscoveryConfigurationFactory, T2, T3, T4, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRegistryDiscoveryConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryDiscoveryConfigurationFactory, T3, T4, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRegistryDiscoveryConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryDiscoveryConfigurationFactory, T4, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRegistryDiscoveryConfigurationFactory, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRegistryDiscoveryConfigurationFactory, InnerRegistryAuthorizerConfigurationFactory> WithAuthorizerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRegistryDiscoveryConfigurationFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizerConfiguration(combinedResult.T5, subFactoryAction).T2);
}
