// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration>
{

    internal InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory SecretsManagerFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration Create()
    {
        var mediaLiveTransitEncryptionKeyConfigurationResult = CreateMediaLiveTransitEncryptionKeyConfiguration();
        factoryAction?.Invoke(mediaLiveTransitEncryptionKeyConfigurationResult);

        return mediaLiveTransitEncryptionKeyConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration CreateMediaLiveTransitEncryptionKeyConfiguration()
    {
        var mediaLiveTransitEncryptionKeyConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration();

        return mediaLiveTransitEncryptionKeyConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration result)
    {
        base.CreateChildren(result);

        result.SecretsManager ??= SecretsManagerFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager(this InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.SecretsManagerFactory = new InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecretsManagerFactory);
    }

    public static CombinedResult<InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T1, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T1, T2, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T2, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T1, T2, T3, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T2, T3, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T3, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T1, T2, T3, T4, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T2, T3, T4, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T3, T4, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T4, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T5, subFactoryAction).T2);
}
