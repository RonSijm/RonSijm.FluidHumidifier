// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputMediaLiveTransitEncryptionFactory(Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption>
{

    internal InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory EncryptionKeyConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption Create()
    {
        var mediaLiveTransitEncryptionResult = CreateMediaLiveTransitEncryption();
        factoryAction?.Invoke(mediaLiveTransitEncryptionResult);

        return mediaLiveTransitEncryptionResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption CreateMediaLiveTransitEncryption()
    {
        var mediaLiveTransitEncryptionResult = new Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption();

        return mediaLiveTransitEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption result)
    {
        base.CreateChildren(result);

        result.EncryptionKeyConfiguration ??= EncryptionKeyConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputMediaLiveTransitEncryptionFactoryExtensions
{
    public static CombinedResult<InnerRouterInputMediaLiveTransitEncryptionFactory, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration(this InnerRouterInputMediaLiveTransitEncryptionFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionKeyConfigurationFactory = new InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionKeyConfigurationFactory);
    }

    public static CombinedResult<InnerRouterInputMediaLiveTransitEncryptionFactory, T1, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1>(this CombinedResult<InnerRouterInputMediaLiveTransitEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionFactory, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1>(this CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMediaLiveTransitEncryptionFactory, T1, T2, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<InnerRouterInputMediaLiveTransitEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionFactory, T2, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMediaLiveTransitEncryptionFactory, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputMediaLiveTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMediaLiveTransitEncryptionFactory, T1, T2, T3, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<InnerRouterInputMediaLiveTransitEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionFactory, T2, T3, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMediaLiveTransitEncryptionFactory, T3, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputMediaLiveTransitEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputMediaLiveTransitEncryptionFactory, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputMediaLiveTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMediaLiveTransitEncryptionFactory, T1, T2, T3, T4, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputMediaLiveTransitEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionFactory, T2, T3, T4, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputMediaLiveTransitEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMediaLiveTransitEncryptionFactory, T3, T4, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputMediaLiveTransitEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputMediaLiveTransitEncryptionFactory, T4, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputMediaLiveTransitEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputMediaLiveTransitEncryptionFactory, InnerRouterInputMediaLiveTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputMediaLiveTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T5, subFactoryAction).T2);
}
