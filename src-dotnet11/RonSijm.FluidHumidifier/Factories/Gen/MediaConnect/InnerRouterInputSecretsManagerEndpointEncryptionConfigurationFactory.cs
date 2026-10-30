// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration>
{

    internal InnerRouterInputEndpointEncryptionSecretConfigurationFactory EncryptionSecretFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration Create()
    {
        var secretsManagerEndpointEncryptionConfigurationResult = CreateSecretsManagerEndpointEncryptionConfiguration();
        factoryAction?.Invoke(secretsManagerEndpointEncryptionConfigurationResult);

        return secretsManagerEndpointEncryptionConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration CreateSecretsManagerEndpointEncryptionConfiguration()
    {
        var secretsManagerEndpointEncryptionConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration();

        return secretsManagerEndpointEncryptionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEndpointEncryptionConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionSecret ??= EncryptionSecretFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret(this InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionSecretFactory = new InnerRouterInputEndpointEncryptionSecretConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionSecretFactory);
    }

    public static CombinedResult<InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T1, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1>(this CombinedResult<InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1>(this CombinedResult<T1, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T1, T2, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2>(this CombinedResult<InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T2, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2>(this CombinedResult<T1, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T1, T2, T3, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3>(this CombinedResult<InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T2, T3, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T3, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T1, T2, T3, T4, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T2, T3, T4, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T3, T4, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T4, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory, InnerRouterInputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputSecretsManagerEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T5, subFactoryAction).T2);
}
