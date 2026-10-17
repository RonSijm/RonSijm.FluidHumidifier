// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration>
{

    internal InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory SecretsManagerFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration Create()
    {
        var mediaLiveTransitEncryptionKeyConfigurationResult = CreateMediaLiveTransitEncryptionKeyConfiguration();
        factoryAction?.Invoke(mediaLiveTransitEncryptionKeyConfigurationResult);

        return mediaLiveTransitEncryptionKeyConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration CreateMediaLiveTransitEncryptionKeyConfiguration()
    {
        var mediaLiveTransitEncryptionKeyConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration();

        return mediaLiveTransitEncryptionKeyConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryptionKeyConfiguration result)
    {
        base.CreateChildren(result);

        result.SecretsManager ??= SecretsManagerFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager(this InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.SecretsManagerFactory = new InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecretsManagerFactory);
    }

    public static CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T1, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T1, T2, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T2, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T1, T2, T3, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T2, T3, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T3, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T1, T2, T3, T4, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T2, T3, T4, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T3, T4, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T4, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputMediaLiveTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T5, subFactoryAction).T2);
}
