// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputEndpointEncryptionConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration>
{

    internal InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory SecretsManagerFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration Create()
    {
        var endpointEncryptionConfigurationResult = CreateEndpointEncryptionConfiguration();
        factoryAction?.Invoke(endpointEncryptionConfigurationResult);

        return endpointEncryptionConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration CreateEndpointEncryptionConfiguration()
    {
        var endpointEncryptionConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration();

        return endpointEncryptionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration result)
    {
        base.CreateChildren(result);

        result.SecretsManager ??= SecretsManagerFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputEndpointEncryptionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputEndpointEncryptionConfigurationFactory, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager(this InnerRouterOutputEndpointEncryptionConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.SecretsManagerFactory = new InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecretsManagerFactory);
    }

    public static CombinedResult<InnerRouterOutputEndpointEncryptionConfigurationFactory, T1, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<InnerRouterOutputEndpointEncryptionConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputEndpointEncryptionConfigurationFactory, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<T1, InnerRouterOutputEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputEndpointEncryptionConfigurationFactory, T1, T2, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<InnerRouterOutputEndpointEncryptionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputEndpointEncryptionConfigurationFactory, T2, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, InnerRouterOutputEndpointEncryptionConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputEndpointEncryptionConfigurationFactory, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputEndpointEncryptionConfigurationFactory, T1, T2, T3, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<InnerRouterOutputEndpointEncryptionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputEndpointEncryptionConfigurationFactory, T2, T3, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputEndpointEncryptionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputEndpointEncryptionConfigurationFactory, T3, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputEndpointEncryptionConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputEndpointEncryptionConfigurationFactory, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputEndpointEncryptionConfigurationFactory, T1, T2, T3, T4, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputEndpointEncryptionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputEndpointEncryptionConfigurationFactory, T2, T3, T4, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputEndpointEncryptionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputEndpointEncryptionConfigurationFactory, T3, T4, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputEndpointEncryptionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputEndpointEncryptionConfigurationFactory, T4, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputEndpointEncryptionConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputEndpointEncryptionConfigurationFactory, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T5, subFactoryAction).T2);
}
