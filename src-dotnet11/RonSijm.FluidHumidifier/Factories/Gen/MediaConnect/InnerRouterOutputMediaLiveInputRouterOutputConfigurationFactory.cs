// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveInputRouterOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveInputRouterOutputConfiguration>
{

    internal InnerRouterOutputMediaLiveTransitEncryptionFactory DestinationTransitEncryptionFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.MediaLiveInputRouterOutputConfiguration Create()
    {
        var mediaLiveInputRouterOutputConfigurationResult = CreateMediaLiveInputRouterOutputConfiguration();
        factoryAction?.Invoke(mediaLiveInputRouterOutputConfigurationResult);

        return mediaLiveInputRouterOutputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.MediaLiveInputRouterOutputConfiguration CreateMediaLiveInputRouterOutputConfiguration()
    {
        var mediaLiveInputRouterOutputConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.MediaLiveInputRouterOutputConfiguration();

        return mediaLiveInputRouterOutputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.MediaLiveInputRouterOutputConfiguration result)
    {
        base.CreateChildren(result);

        result.DestinationTransitEncryption ??= DestinationTransitEncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption(this InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null)
    {
        parentFactory.DestinationTransitEncryptionFactory = new InnerRouterOutputMediaLiveTransitEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationTransitEncryptionFactory);
    }

    public static CombinedResult<InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T1, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption<T1>(this CombinedResult<InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption<T1>(this CombinedResult<T1, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T1, T2, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2>(this CombinedResult<InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T2, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2>(this CombinedResult<T1, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T1, T2, T3, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3>(this CombinedResult<InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T2, T3, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T3, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T1, T2, T3, T4, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T2, T3, T4, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T3, T4, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T4, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory, InnerRouterOutputMediaLiveTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputMediaLiveInputRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.MediaLiveTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T5, subFactoryAction).T2);
}
