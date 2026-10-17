// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryAuthorizerConfigurationFactory(Action<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration>
{

    internal InnerRegistryCustomJWTAuthorizerConfigurationFactory CustomJWTAuthorizerFactory { get; set; }

    protected override Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration Create()
    {
        var authorizerConfigurationResult = CreateAuthorizerConfiguration();
        factoryAction?.Invoke(authorizerConfigurationResult);

        return authorizerConfigurationResult;
    }

    private Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration CreateAuthorizerConfiguration()
    {
        var authorizerConfigurationResult = new Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration();

        return authorizerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration result)
    {
        base.CreateChildren(result);

        result.CustomJWTAuthorizer ??= CustomJWTAuthorizerFactory?.Build();
    }

} // End Of Class

public static class InnerRegistryAuthorizerConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRegistryAuthorizerConfigurationFactory, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer(this InnerRegistryAuthorizerConfigurationFactory parentFactory, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null)
    {
        parentFactory.CustomJWTAuthorizerFactory = new InnerRegistryCustomJWTAuthorizerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomJWTAuthorizerFactory);
    }

    public static CombinedResult<InnerRegistryAuthorizerConfigurationFactory, T1, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1>(this CombinedResult<InnerRegistryAuthorizerConfigurationFactory, T1> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryAuthorizerConfigurationFactory, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1>(this CombinedResult<T1, InnerRegistryAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryAuthorizerConfigurationFactory, T1, T2, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<InnerRegistryAuthorizerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryAuthorizerConfigurationFactory, T2, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<T1, InnerRegistryAuthorizerConfigurationFactory, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryAuthorizerConfigurationFactory, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2>(this CombinedResult<T1, T2, InnerRegistryAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryAuthorizerConfigurationFactory, T1, T2, T3, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<InnerRegistryAuthorizerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryAuthorizerConfigurationFactory, T2, T3, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, InnerRegistryAuthorizerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryAuthorizerConfigurationFactory, T3, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, T2, InnerRegistryAuthorizerConfigurationFactory, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryAuthorizerConfigurationFactory, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRegistryAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryAuthorizerConfigurationFactory, T1, T2, T3, T4, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<InnerRegistryAuthorizerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryAuthorizerConfigurationFactory, T2, T3, T4, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, InnerRegistryAuthorizerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryAuthorizerConfigurationFactory, T3, T4, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRegistryAuthorizerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryAuthorizerConfigurationFactory, T4, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRegistryAuthorizerConfigurationFactory, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRegistryAuthorizerConfigurationFactory, InnerRegistryCustomJWTAuthorizerConfigurationFactory> WithCustomJWTAuthorizer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRegistryAuthorizerConfigurationFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomJWTAuthorizer(combinedResult.T5, subFactoryAction).T2);
}
