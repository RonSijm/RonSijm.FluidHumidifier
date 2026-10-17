// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputSrtEncryptionConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration>
{

    internal InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory EncryptionKeyFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration Create()
    {
        var srtEncryptionConfigurationResult = CreateSrtEncryptionConfiguration();
        factoryAction?.Invoke(srtEncryptionConfigurationResult);

        return srtEncryptionConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration CreateSrtEncryptionConfiguration()
    {
        var srtEncryptionConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration();

        return srtEncryptionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.SrtEncryptionConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionKey ??= EncryptionKeyFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputSrtEncryptionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputSrtEncryptionConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey(this InnerRouterOutputSrtEncryptionConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionKeyFactory = new InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionKeyFactory);
    }

    public static CombinedResult<InnerRouterOutputSrtEncryptionConfigurationFactory, T1, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1>(this CombinedResult<InnerRouterOutputSrtEncryptionConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSrtEncryptionConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1>(this CombinedResult<T1, InnerRouterOutputSrtEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSrtEncryptionConfigurationFactory, T1, T2, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2>(this CombinedResult<InnerRouterOutputSrtEncryptionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSrtEncryptionConfigurationFactory, T2, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2>(this CombinedResult<T1, InnerRouterOutputSrtEncryptionConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSrtEncryptionConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputSrtEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSrtEncryptionConfigurationFactory, T1, T2, T3, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<InnerRouterOutputSrtEncryptionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSrtEncryptionConfigurationFactory, T2, T3, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputSrtEncryptionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSrtEncryptionConfigurationFactory, T3, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputSrtEncryptionConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputSrtEncryptionConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputSrtEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSrtEncryptionConfigurationFactory, T1, T2, T3, T4, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputSrtEncryptionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSrtEncryptionConfigurationFactory, T2, T3, T4, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputSrtEncryptionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSrtEncryptionConfigurationFactory, T3, T4, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputSrtEncryptionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputSrtEncryptionConfigurationFactory, T4, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputSrtEncryptionConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputSrtEncryptionConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputSrtEncryptionConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T5, subFactoryAction).T2);
}
