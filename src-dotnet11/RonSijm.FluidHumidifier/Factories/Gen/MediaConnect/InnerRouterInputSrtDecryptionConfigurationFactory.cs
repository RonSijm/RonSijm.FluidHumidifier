// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputSrtDecryptionConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration>
{

    internal InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory EncryptionKeyFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration Create()
    {
        var srtDecryptionConfigurationResult = CreateSrtDecryptionConfiguration();
        factoryAction?.Invoke(srtDecryptionConfigurationResult);

        return srtDecryptionConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration CreateSrtDecryptionConfiguration()
    {
        var srtDecryptionConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration();

        return srtDecryptionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.SrtDecryptionConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionKey ??= EncryptionKeyFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputSrtDecryptionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterInputSrtDecryptionConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey(this InnerRouterInputSrtDecryptionConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionKeyFactory = new InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionKeyFactory);
    }

    public static CombinedResult<InnerRouterInputSrtDecryptionConfigurationFactory, T1, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1>(this CombinedResult<InnerRouterInputSrtDecryptionConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSrtDecryptionConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1>(this CombinedResult<T1, InnerRouterInputSrtDecryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputSrtDecryptionConfigurationFactory, T1, T2, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2>(this CombinedResult<InnerRouterInputSrtDecryptionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSrtDecryptionConfigurationFactory, T2, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2>(this CombinedResult<T1, InnerRouterInputSrtDecryptionConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputSrtDecryptionConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputSrtDecryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputSrtDecryptionConfigurationFactory, T1, T2, T3, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<InnerRouterInputSrtDecryptionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSrtDecryptionConfigurationFactory, T2, T3, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputSrtDecryptionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputSrtDecryptionConfigurationFactory, T3, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputSrtDecryptionConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputSrtDecryptionConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputSrtDecryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputSrtDecryptionConfigurationFactory, T1, T2, T3, T4, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputSrtDecryptionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputSrtDecryptionConfigurationFactory, T2, T3, T4, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputSrtDecryptionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputSrtDecryptionConfigurationFactory, T3, T4, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputSrtDecryptionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputSrtDecryptionConfigurationFactory, T4, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputSrtDecryptionConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputSrtDecryptionConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputSrtDecryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T5, subFactoryAction).T2);
}
