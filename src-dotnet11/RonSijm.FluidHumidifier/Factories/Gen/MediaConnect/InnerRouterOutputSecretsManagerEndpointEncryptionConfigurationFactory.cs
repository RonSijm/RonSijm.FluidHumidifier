// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration>
{

    internal InnerRouterOutputEndpointEncryptionSecretConfigurationFactory EncryptionSecretFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration Create()
    {
        var secretsManagerEndpointEncryptionConfigurationResult = CreateSecretsManagerEndpointEncryptionConfiguration();
        factoryAction?.Invoke(secretsManagerEndpointEncryptionConfigurationResult);

        return secretsManagerEndpointEncryptionConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration CreateSecretsManagerEndpointEncryptionConfiguration()
    {
        var secretsManagerEndpointEncryptionConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration();

        return secretsManagerEndpointEncryptionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEndpointEncryptionConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionSecret ??= EncryptionSecretFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret(this InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionSecretFactory = new InnerRouterOutputEndpointEncryptionSecretConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionSecretFactory);
    }

    public static CombinedResult<InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T1, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1>(this CombinedResult<InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1>(this CombinedResult<T1, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T1, T2, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2>(this CombinedResult<InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T2, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2>(this CombinedResult<T1, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T1, T2, T3, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3>(this CombinedResult<InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T2, T3, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T3, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T1, T2, T3, T4, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T2, T3, T4, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T3, T4, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T4, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory, InnerRouterOutputEndpointEncryptionSecretConfigurationFactory> WithEncryptionSecret<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputSecretsManagerEndpointEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionSecret(combinedResult.T5, subFactoryAction).T2);
}
