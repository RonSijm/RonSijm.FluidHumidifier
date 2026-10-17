// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveChannelRouterInputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.MediaLiveChannelRouterInputConfiguration>
{

    internal InnerRouterInputMediaLiveTransitEncryptionFactory SourceTransitDecryptionFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.MediaLiveChannelRouterInputConfiguration Create()
    {
        var mediaLiveChannelRouterInputConfigurationResult = CreateMediaLiveChannelRouterInputConfiguration();
        factoryAction?.Invoke(mediaLiveChannelRouterInputConfigurationResult);

        return mediaLiveChannelRouterInputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.MediaLiveChannelRouterInputConfiguration CreateMediaLiveChannelRouterInputConfiguration()
    {
        var mediaLiveChannelRouterInputConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.MediaLiveChannelRouterInputConfiguration();

        return mediaLiveChannelRouterInputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.MediaLiveChannelRouterInputConfiguration result)
    {
        base.CreateChildren(result);

        result.SourceTransitDecryption ??= SourceTransitDecryptionFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputMediaLiveChannelRouterInputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption(this InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null)
    {
        parentFactory.SourceTransitDecryptionFactory = new InnerRouterInputMediaLiveTransitEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceTransitDecryptionFactory);
    }

    public static CombinedResult<InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T1, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption<T1>(this CombinedResult<InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption<T1>(this CombinedResult<T1, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T1, T2, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2>(this CombinedResult<InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T2, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2>(this CombinedResult<T1, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T1, T2, T3, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3>(this CombinedResult<InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T2, T3, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T3, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T1, T2, T3, T4, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T2, T3, T4, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T3, T4, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T4, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory, InnerRouterInputMediaLiveTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputMediaLiveChannelRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T5, subFactoryAction).T2);
}
