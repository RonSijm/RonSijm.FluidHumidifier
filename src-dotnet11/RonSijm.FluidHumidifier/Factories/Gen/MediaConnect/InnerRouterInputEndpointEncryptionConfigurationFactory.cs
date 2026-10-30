// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputEndpointEncryptionConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration>
{

    internal InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory SecretsManagerFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration Create()
    {
        var endpointEncryptionConfigurationResult = CreateEndpointEncryptionConfiguration();
        factoryAction?.Invoke(endpointEncryptionConfigurationResult);

        return endpointEncryptionConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration CreateEndpointEncryptionConfiguration()
    {
        var endpointEncryptionConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration();

        return endpointEncryptionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration result)
    {
        base.CreateChildren(result);

        result.SecretsManager ??= SecretsManagerFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputEndpointEncryptionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterInputEndpointEncryptionConfigurationFactory, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager(this InnerRouterInputEndpointEncryptionConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.SecretsManagerFactory = new InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecretsManagerFactory);
    }

    public static CombinedResult<InnerRouterInputEndpointEncryptionConfigurationFactory, T1, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<InnerRouterInputEndpointEncryptionConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputEndpointEncryptionConfigurationFactory, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<T1, InnerRouterInputEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputEndpointEncryptionConfigurationFactory, T1, T2, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<InnerRouterInputEndpointEncryptionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputEndpointEncryptionConfigurationFactory, T2, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, InnerRouterInputEndpointEncryptionConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputEndpointEncryptionConfigurationFactory, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputEndpointEncryptionConfigurationFactory, T1, T2, T3, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<InnerRouterInputEndpointEncryptionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputEndpointEncryptionConfigurationFactory, T2, T3, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputEndpointEncryptionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputEndpointEncryptionConfigurationFactory, T3, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputEndpointEncryptionConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputEndpointEncryptionConfigurationFactory, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputEndpointEncryptionConfigurationFactory, T1, T2, T3, T4, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputEndpointEncryptionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputEndpointEncryptionConfigurationFactory, T2, T3, T4, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputEndpointEncryptionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputEndpointEncryptionConfigurationFactory, T3, T4, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputEndpointEncryptionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputEndpointEncryptionConfigurationFactory, T4, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputEndpointEncryptionConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputEndpointEncryptionConfigurationFactory, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T5, subFactoryAction).T2);
}
